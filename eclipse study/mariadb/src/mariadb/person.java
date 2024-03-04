package mariadb;

class person {
	
    private String name;
    private String age;
    private String gender;
    private String phoneNumber;
    private String MBTI;
    private String address;
    private String nickName;
    private String group;
    
    public person(String name, String age, String gender,
    		String phoneNumber, String MBTI, String address,
    		String NickName, String group) {
    	
    	this.name = name;
    	this.age = age;
    	this.gender = gender;
    	this.phoneNumber = phoneNumber;
    	this.MBTI = MBTI;
    	this.address = address;
    	this.nickName = NickName; 
    	this.group = group;
    	
    }
    public String getName() {
        return name;
    }
    public String getGroup() {
        return group;
    }
    @Override
    public String toString() {
        return "이름 : " + name + "\n" +
                "나이 : " + age + "\n" +
                "성별 : " + gender + "\n" +
                "전화번호 : " + phoneNumber + "\n" +
                "MBTI : " + MBTI + "\n" +
                "주소 : " + address + "\n" +
                "별명 : " + nickName + "\n" +
                "그룹 : " + group;
    }
}
