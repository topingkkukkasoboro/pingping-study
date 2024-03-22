package com.ea.restapi05.member;

public enum Role {
    USER, ADMIN;

    public static Role fromString(String userRole) {
        for(Role role : Role.values()) {
            if(role.toString().equalsIgnoreCase(userRole)) {
                return role;
            }
        }
        // 여기까지 도달하면 USER도 아니고 ADMIN도 아닌 이상한 userRole
        return null;
    }
}
