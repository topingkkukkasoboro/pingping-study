using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace remake.dagtbase
{
    public class MainDB
    {
        public static List<String> Movie1()
        {
            List<String> movie1 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '1' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 1";
            using (OracleCommand command = new OracleCommand(sql, con))
            {

                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie1.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie1;
        }
        public static List<String> Movie1To2()
        {
            List<String> movie1to2 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '1' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 2";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie1to2.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie1to2;
        }
        public static List<String> Movie1To3()
        {
            List<String> movie1to3 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '1' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 3";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie1to3.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie1to3;
        }
        public static List<String> Movie2()
        {
            List<String> movie2 = new List<String>();
            movie2.Clear();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '2' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 1";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie2.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie2;
        }
        public static List<String> Movie2To2()
        {
            List<String> movie2to2 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '2' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 2";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie2to2.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie2to2;
        }
        public static List<String> Movie2To3()
        {
            List<String> movie2to3 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '2' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 3";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie2to3.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie2to3;
        }
        public static List<String> Movie3()
        {
            List<String> movie3 = new List<String>();
            movie3.Clear();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '3' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 1";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie3.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie3;
        }
        public static List<String> Movie3To2()
        {
            List<String> movie3to2 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '3' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 2";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie3to2.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie3to2;
        }
        public static List<String> Movie3To3()
        {
            List<String> movie3to3 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '3' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 3";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie3to3.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie3to3;
        }
        public static List<String> Movie4()
        {
            List<String> movie4 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '4' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 1";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie4.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie4;
        }
        public static List<String> Movie4To2()
        {
            List<String> movie4to2 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '4' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 2";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie4to2.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie4to2;
        }
        public static List<String> Movie4To3()
        {
            List<String> movie4to3 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '4' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 3";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie4to3.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie4to3;
        }
        public static List<String> Movie5()
        {
            List<String> movie5 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '5' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 1";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie5.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie5;
        }
        public static List<String> Movie5To2()
        {
            List<String> movie5to2 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '5' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 2";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie5to2.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie5to2;
        }
        public static List<String> Movie5To3()
        {
            List<String> movie5to3 = new List<String>();
            OracleConnection con = DBInfo.openconnect();
            string sql = @" SELECT * FROM (
                            SELECT a.시간표, a.상영관, a.시작시간, a.종료시간, b.영화명, b.상영등급, b.러닝타임, b.줄거리, ROWNUM AS row_number
                            FROM 시간표 a JOIN 영화 b ON a.영화번호 = b.영화번호 WHERE a.영화번호 = '5' AND a.시작시간 > sysdate +9/24
                            ORDER BY a.시작시간 ASC) WHERE row_number = 3";
            using (OracleCommand command = new OracleCommand(sql, con))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            movie5to3.Add(reader.GetString(i));
                        }
                    }
                }
            }
            DBInfo.closeconnect();
            return movie5to3;
        }
    }
}
