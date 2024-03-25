package com.mh.fileex.file;

import lombok.RequiredArgsConstructor;
import org.springframework.core.io.FileUrlResource;
import org.springframework.core.io.Resource;
import org.springframework.core.io.UrlResource;
import org.springframework.hateoas.EntityModel;
import org.springframework.hateoas.server.mvc.WebMvcLinkBuilder;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;

import javax.swing.text.html.parser.Entity;
import java.io.File;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api/file")
public class FileController {

    private final Path imagePath;
    public FileController() { // 파일 저장 경로 // 폴더 생성
        imagePath = Paths.get("src/main/resources/static/images/upload/")
                .toAbsolutePath().normalize();
    try {
        Files.createDirectories(this.imagePath); // 해당 경로에 디렉토리를생생해라
    }catch (Exception e){
        e.printStackTrace();
    }
    }
    @PostMapping("/upload") // 파일 등록 및 저장
    public EntityModel<FileDto> uploadFile(@RequestParam("file") MultipartFile file){
         try {
             System.out.println(file.getContentType());
             System.out.println(imagePath + "/" + file.getOriginalFilename());

             File dest = new File(imagePath + "/" + file.getOriginalFilename());
             file.transferTo(dest);

             EntityModel<FileDto> entitymodel = EntityModel.of(new FileDto(file.getOriginalFilename()));
             entitymodel.add(
                     WebMvcLinkBuilder
                             .linkTo(
                                     WebMvcLinkBuilder
                     .methodOn(FileController.class)
                     .getImage(file.getOriginalFilename())).withRel("download"));
             return entitymodel;
         }catch (Exception e){
             e.printStackTrace();
             return null;
         }

    }
    @GetMapping("/download/{fileName}")
    public ResponseEntity<Resource> getImage(@PathVariable String fileName){
        System.out.println(fileName);
        Path filePath = this.imagePath.resolve(fileName).normalize();
        Resource resource = null;
        try {
        resource = new UrlResource(filePath.toUri());
        }catch (Exception e){
        e.printStackTrace();
        // 파일이 없을때 파일이 없다는 상태 값 보내기
        }
        // 파일이 있을때는 해당되는 파일 리소스 보내기
        return ResponseEntity.ok().body(resource);

    }
}
