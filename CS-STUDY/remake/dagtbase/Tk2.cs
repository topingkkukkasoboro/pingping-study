using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remake.dagtbase
{
    public class Tk2
    {

        public string mv1() //tickting의 movie1time1
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = @"
                SELECT TO_CHAR(시작시간, 'HH24:MI') AS 시작시간
                FROM (
                    SELECT 시작시간, ROWNUM AS rn
                    FROM (
                        SELECT 시작시간
                        FROM 시간표 
                        WHERE 영화번호 = '1' AND 시작시간 > SYSDATE + 9/24
                        ORDER BY 시작시간
                    )
                )
                WHERE rn = 1";

            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간1 = reader.GetString(0);
                        return 시작시간1;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public int mbth1()
        {
            String 시작시간1 = mv1();
            OracleConnection con = DBInfo.openconnect();
            string sql2 = $@"
             SELECT count(좌석유무) FROM 좌석 WHERE 시간표 IN (SELECT 시간표 FROM 시간표
             WHERE TO_CHAR(시작시간, 'HH24:MI') = '{시작시간1}' AND 상영관 = '1관'  AND 좌석유무 = '0')";
            using (OracleCommand command = new OracleCommand(sql2, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int 남은좌석1 = reader.GetInt32(0);
                        return 남은좌석1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public String timetable1()
        {
            String 시작시간1 = mv1();
            OracleConnection con = DBInfo.openconnect();
            String sql3 = $@"SELECT 시간표 from 시간표 where 상영관 ='1관' and to_char(시작시간, 'HH24:MI') ='{시작시간1}'";
            using (OracleCommand command = new OracleCommand(sql3, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String 시간표1 = reader.GetString(0);
                        return 시간표1;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public String mv2()//tickting의 movie1time2
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = @"
                SELECT TO_CHAR(시작시간, 'HH24:MI') AS 시작시간
                FROM (
                    SELECT 시작시간, ROWNUM AS rn
                    FROM (
                        SELECT 시작시간
                        FROM 시간표 
                        WHERE 영화번호 = '1' AND 시작시간 > SYSDATE + 9/24
                        ORDER BY 시작시간
                    )
                )
                WHERE rn = 2";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간2 = reader.GetString(0);
                        return 시작시간2;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public int mbth2()
        {
            String 시작시간2 = mv2();
            OracleConnection con = DBInfo.openconnect();
            string sql2 = $@"
             SELECT count(좌석유무) FROM 좌석 WHERE 시간표 IN (SELECT 시간표 FROM 시간표
             WHERE TO_CHAR(시작시간, 'HH24:MI') = '{시작시간2}' AND 상영관 = '1관'  AND 좌석유무 = '0')";
            using (OracleCommand command = new OracleCommand(sql2, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int 남은좌석2 = reader.GetInt32(0);
                        return 남은좌석2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public String timetable2()
        {
            String 시작시간2 = mv2();
            OracleConnection con = DBInfo.openconnect();
            String sql3 = $@"SELECT 시간표 from 시간표 where 상영관 ='1관' and to_char(시작시간, 'HH24:MI') ='{시작시간2}'";
            using (OracleCommand command = new OracleCommand(sql3, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String 시간표2 = reader.GetString(0);
                        return 시간표2;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public String mv3()//tickting의 movie1time3
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = @"
                SELECT TO_CHAR(시작시간, 'HH24:MI') AS 시작시간
                FROM (
                    SELECT 시작시간, ROWNUM AS rn
                    FROM (
                        SELECT 시작시간
                        FROM 시간표 
                        WHERE 영화번호 = '1' AND 시작시간 > SYSDATE + 9/24
                        ORDER BY 시작시간
                    )
                )
                WHERE rn = 3";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간3 = reader.GetString(0);
                        return 시작시간3;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public String timetable3()
        {
            String 시작시간3 = mv3();
            OracleConnection con = DBInfo.openconnect();
            String sql3 = $@"SELECT 시간표 from 시간표 where 상영관 ='1관' and to_char(시작시간, 'HH24:MI') ='{시작시간3}'";
            using (OracleCommand command = new OracleCommand(sql3, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String 시간표3 = reader.GetString(0);
                        return 시간표3;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public int mbth3()
        {
            String 시작시간3 = mv3();
            OracleConnection con = DBInfo.openconnect();
            string sql2 = $@"
             SELECT count(좌석유무) FROM 좌석 WHERE 시간표 IN (SELECT 시간표 FROM 시간표
             WHERE TO_CHAR(시작시간, 'HH24:MI') = '{시작시간3}' AND 상영관 = '1관'  AND 좌석유무 = '0')";
            using (OracleCommand command = new OracleCommand(sql2, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int 남은좌석3 = reader.GetInt32(0);
                        return 남은좌석3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public String mv4()
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = @"
                SELECT TO_CHAR(시작시간, 'HH24:MI') AS 시작시간
                FROM (
                    SELECT 시작시간, ROWNUM AS rn
                    FROM (
                        SELECT 시작시간
                        FROM 시간표 
                        WHERE 영화번호 = '2' AND 시작시간 > SYSDATE + 9/24
                        ORDER BY 시작시간
                    )
                )
                WHERE rn = 1";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간4 = reader.GetString(0);
                        return 시작시간4;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public String timetable4()
        {
            String 시작시간4 = mv4();
            OracleConnection con = DBInfo.openconnect();
            String sql3 = $@"SELECT 시간표 from 시간표 where 상영관 ='2관' and to_char(시작시간, 'HH24:MI') ='{시작시간4}'";
            using (OracleCommand command = new OracleCommand(sql3, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String 시간표4 = reader.GetString(0);
                        return 시간표4;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public int mbth4()
        {
            String 시작시간4 = mv4();
            OracleConnection con = DBInfo.openconnect();
            string sql2 = $@"
             SELECT count(좌석유무) FROM 좌석 WHERE 시간표 IN (SELECT 시간표 FROM 시간표
             WHERE TO_CHAR(시작시간, 'HH24:MI') = '{시작시간4}' AND 상영관 = '2관'  AND 좌석유무 = '0')";
            using (OracleCommand command = new OracleCommand(sql2, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int 남은좌석1 = reader.GetInt32(0);
                        return 남은좌석1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public String mv5()
        {
            OracleConnection con = DBInfo.openconnect();

            string sql = @"
                SELECT TO_CHAR(시작시간, 'HH24:MI') AS 시작시간
                FROM (
                    SELECT 시작시간, ROWNUM AS rn
                    FROM (
                        SELECT 시작시간
                        FROM 시간표 
                        WHERE 영화번호 = '2' AND 시작시간 > SYSDATE + 9/24
                        ORDER BY 시작시간
                    )
                )
                WHERE rn = 2";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간5 = reader.GetString(0);
                        return 시작시간5;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public int mbth5()
        {
            String 시작시간5 = mv5();
            OracleConnection con = DBInfo.openconnect();
            string sql2 = $@"
             SELECT count(좌석유무) FROM 좌석 WHERE 시간표 IN (SELECT 시간표 FROM 시간표
             WHERE TO_CHAR(시작시간, 'HH24:MI') = '{시작시간5}' AND 상영관 = '2관'  AND 좌석유무 = '0')";
            using (OracleCommand command = new OracleCommand(sql2, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int 남은좌석5 = reader.GetInt32(0);
                        return 남은좌석5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public String timetable5()
        {
            String 시작시간5 = mv5();
            OracleConnection con = DBInfo.openconnect();
            String sql3 = $@"SELECT 시간표 from 시간표 where 상영관 ='2관' and to_char(시작시간, 'HH24:MI') ='{시작시간5}'";
            using (OracleCommand command = new OracleCommand(sql3, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String 시간표5 = reader.GetString(0);
                        return 시간표5;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public String mv6()
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = @"
                SELECT TO_CHAR(시작시간, 'HH24:MI') AS 시작시간
                FROM (
                    SELECT 시작시간, ROWNUM AS rn
                    FROM (
                        SELECT 시작시간
                        FROM 시간표 
                        WHERE 영화번호 = '2' AND 시작시간 > SYSDATE + 9/24
                        ORDER BY 시작시간
                    )
                )
                WHERE rn = 3";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간6 = reader.GetString(0);
                        return 시작시간6;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public int mbth6()
        {
            String 시작시간6 = mv6();
            OracleConnection con = DBInfo.openconnect();
            string sql2 = $@"
             SELECT count(좌석유무) FROM 좌석 WHERE 시간표 IN (SELECT 시간표 FROM 시간표
             WHERE TO_CHAR(시작시간, 'HH24:MI') = '{시작시간6}' AND 상영관 = '2관'  AND 좌석유무 = '0')";
            using (OracleCommand command = new OracleCommand(sql2, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int 남은좌석6 = reader.GetInt32(0);
                        return 남은좌석6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public String timetable6()
        {
            String 시작시간6 = mv6();
            OracleConnection con = DBInfo.openconnect();
            String sql3 = $@"SELECT 시간표 from 시간표 where 상영관 ='2관' and to_char(시작시간, 'HH24:MI') ='{시작시간6}'";
            using (OracleCommand command = new OracleCommand(sql3, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String 시간표6 = reader.GetString(0);
                        return 시간표6;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public String mv7()
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = @"
                SELECT TO_CHAR(시작시간, 'HH24:MI') AS 시작시간
                FROM (
                    SELECT 시작시간, ROWNUM AS rn
                    FROM (
                        SELECT 시작시간
                        FROM 시간표 
                        WHERE 영화번호 = '3' AND 시작시간 > SYSDATE + 9/24
                        ORDER BY 시작시간
                    )
                )
                WHERE rn = 1";


            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간7 = reader.GetString(0);
                        return 시작시간7;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public int mbth7()
        {
            String 시작시간7 = mv7();
            OracleConnection con = DBInfo.openconnect();
            string sql2 = $@"
             SELECT count(좌석유무) FROM 좌석 WHERE 시간표 IN (SELECT 시간표 FROM 시간표
             WHERE TO_CHAR(시작시간, 'HH24:MI') = '{시작시간7}' AND 상영관 = '3관'  AND 좌석유무 = '0')";
            using (OracleCommand command = new OracleCommand(sql2, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int 남은좌석7 = reader.GetInt32(0);
                        return 남은좌석7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public String timetable7()
        {
            String 시작시간7 = mv7();
            OracleConnection con = DBInfo.openconnect();
            String sql3 = $@"SELECT 시간표 from 시간표 where 상영관 ='3관' and to_char(시작시간, 'HH24:MI') ='{시작시간7}'";
            using (OracleCommand command = new OracleCommand(sql3, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String 시간표7 = reader.GetString(0);
                        return 시간표7;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public String mv8()
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = @"
                SELECT TO_CHAR(시작시간, 'HH24:MI') AS 시작시간
                FROM (
                    SELECT 시작시간, ROWNUM AS rn
                    FROM (
                        SELECT 시작시간
                        FROM 시간표 
                         WHERE 영화번호 = '3' AND 시작시간 > SYSDATE + 9/24
                        ORDER BY 시작시간
                    )
                )
                WHERE rn = 2";


            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간8 = reader.GetString(0);
                        return 시작시간8;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public int mbth8()
        {
            String 시작시간8 = mv8();
            OracleConnection con = DBInfo.openconnect();
            string sql2 = $@"
             SELECT count(좌석유무) FROM 좌석 WHERE 시간표 IN (SELECT 시간표 FROM 시간표
             WHERE TO_CHAR(시작시간, 'HH24:MI') = '{시작시간8}' AND 상영관 = '3관'  AND 좌석유무 = '0')";
            using (OracleCommand command = new OracleCommand(sql2, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int 남은좌석8 = reader.GetInt32(0);
                        return 남은좌석8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public String timetable8()
        {
            String 시작시간8 = mv8();
            OracleConnection con = DBInfo.openconnect();
            String sql3 = $@"SELECT 시간표 from 시간표 where 상영관 ='3관' and to_char(시작시간, 'HH24:MI') ='{시작시간8}'";
            using (OracleCommand command = new OracleCommand(sql3, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String 시간표8 = reader.GetString(0);
                        return 시간표8;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public String mv9()
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = @"
                SELECT TO_CHAR(시작시간, 'HH24:MI') AS 시작시간
                FROM (
                    SELECT 시작시간, ROWNUM AS rn
                    FROM (
                        SELECT 시작시간
                        FROM 시간표 
                         WHERE 영화번호 = '3' AND 시작시간 > SYSDATE + 9/24
                        ORDER BY 시작시간
                    )
                )
                WHERE rn = 3";


            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간9 = reader.GetString(0);
                        return 시작시간9;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public int mbth9()
        {
            String 시작시간9 = mv9();
            OracleConnection con = DBInfo.openconnect();
            string sql2 = $@"
             SELECT count(좌석유무) FROM 좌석 WHERE 시간표 IN (SELECT 시간표 FROM 시간표
             WHERE TO_CHAR(시작시간, 'HH24:MI') = '{시작시간9}' AND 상영관 = '3관'  AND 좌석유무 = '0')";
            using (OracleCommand command = new OracleCommand(sql2, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int 남은좌석9 = reader.GetInt32(0);
                        return 남은좌석9;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public String timetable9()
        {
            String 시작시간9 = mv9();
            OracleConnection con = DBInfo.openconnect();
            String sql3 = $@"SELECT 시간표 from 시간표 where 상영관 ='3관' and to_char(시작시간, 'HH24:MI') ='{시작시간9}'";
            using (OracleCommand command = new OracleCommand(sql3, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String 시간표9 = reader.GetString(0);
                        return 시간표9;
                    }
                    else
                    {
                        return "상영종료";
                    }
                }
            }
        }
        public string MovieName1()
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = "select 영화명 from 영화 where 영화번호 = '1'";

                using (OracleCommand command = new OracleCommand(sql, con))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string 영화명 = reader.GetString(0);
                            return 영화명;
                        }
                        else
                        {
                            return "없다 머글들아";
                        }
                    }
                }
            }
        
        public String MovieName2()
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = "select 영화명 from 영화 where 영화번호 = '2'";


            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간 = reader.GetString(0);
                        return 시작시간;
                    }
                    else
                    {
                        return "없다 머글들아";
                    }
                }
            }
        }
        public String MovieName3()
        {
            OracleConnection con = DBInfo.openconnect();
            string sql = "select 영화명 from 영화 where 영화번호 = '3'";


            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string 시작시간 = reader.GetString(0);
                        return 시작시간;
                    }
                    else
                    {
                        return "없다 머글들아";
                    }
                }
            }

        }
    }
}
