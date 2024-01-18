package aaa;

public class Person { // 어디서든 불러올려면 public
	
	private String name;
	private String phone;
	
	public Person() {
		doAction();
	}
	
	protected void doAction() {
		System.out.println(name + "이 움직입니다.");
	}
	
	// alt + shift + s -> r
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public String getPhone() {
		return phone;
	}
	public void setPhone(String phone) {
		this.phone = phone;
	}
	
	
	
	
}
