using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 泛型
            //Calc<int> c1 = new Calc<int>();
            //Calc<float> c2 = new Calc<float>();

            //Calc c1 = new Calc();
            //c1.Minus<int>(10);
            //c1.Minus<string>("");

            //Test<Dog> t1 = new Test<Dog>();
            //#endregion

            //#region List<T>集合
            //List<string> list1 = new List<string>();
            //list1.Add("中国"); //往集合里面添加
            //Console.WriteLine(list1.Count);  //表示集合元素的个数
            //list1.Add("美国");
            //Console.WriteLine(list1.Count);
            //list1.Add("英国");
            //Console.WriteLine(list1.Count);
            //list1.AddRange(new string[] { "越南", "日本", "韩国" });

            //Console.WriteLine(list1[1]);  //显示 美国
            //list1.RemoveAt(1); //删除美国
            //list1.Clear();

            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Dictionary<TKey,TValue>
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("中", "四边形的中心，中间");
            //dic.Add("国", "一个有管理的地方");
            ////Console.WriteLine(dic["中"]);

            //foreach (var item in dic)
            //{
            //    Console.WriteLine("Key:" + item.Key + "  Value" + item.Value);
            //}

            #endregion

            #region 文件读写操作
            ////写操作
            //using (FileStream streamWrite = new FileStream(@"C: \Users\Administrator\Desktop\hello.txt", FileMode.Create, FileAccess.Write))
            //{
            //    byte[] bs = Encoding.GetEncoding("Gb2312")"中国一定强"  //自己得到一个代码类型
            //    byte[] bs1 = Encoding.UTF8.GetBytes("中国一定强");
            //    streamWrite.Write(bs1, 0, bs1.Length);

            //}

            //Console.WriteLine("ok");

            ////streamWrite.Close();
            // //streamWrite.Dispose();

            //读操作
            //using (FileStream streamRead = new FileStream(@"C: \Users\Administrator\Desktop\hello.txt", FileMode.Open, FileAccess.Read))
            //{
            //    byte[] bs = new byte[1024];
            //    int len = streamRead.Read(bs, 0, 1024);
            //    while (len > 0)
            //    {
            //        string s1 = Encoding.UTF8.GetString(bs, 0, len);
            //        Console.WriteLine(s1);

            //        len = streamRead.Read(bs, 0, 1024);
            //    }
            //}


            #endregion

            #region MySql查询多行多列
            //读取
            //string connStr = "data source=localhost;database=mmorpg;user id=root;password=123456;pooling=false;charset=utf8;";
            //using (MySqlConnection conn = new MySqlConnection(connStr))
            //{
            //    string sql = "select * from users1";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    conn.Open();
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    Console.WriteLine("编码\t用户名\t密码");
            //    while (reader.Read())
            //    {
            //        Console.Write(reader.GetInt32(0) + "\t");
            //        if (reader.IsDBNull(1))
            //        {
            //            Console.Write("\t");
            //        }
            //        else
            //        {
            //            Console.Write(reader.GetString("uname") + "\t");
            //        }

            //        if (reader.IsDBNull(2))
            //        {
            //            Console.Write("\t");
            //        }
            //        else
            //        {
            //            Console.WriteLine(reader.GetString(2));
            //        }
            //    }


            //}
            #endregion

            #region 注册（添加）
            //using (MySqlConnection conn = new MySqlConnection(connStr))
            //{
            //    Console.WriteLine("请输入用户名：");
            //    string uname = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    string upwd = Console.ReadLine();
            //    //string sql = "insert into users1(uname,upwd) values('"+uname+"','"+upwd+"')";
            //    string sql = "insert into users1(uname,upwd) values(@name,@pwd)";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    cmd.Parameters.Add(new MySqlParameter("@name", uname));
            //    cmd.Parameters.Add(new MySqlParameter("@pwd", upwd));

            //    conn.Open();

            //    int rowsCount = cmd.ExecuteNonQuery();
            //    if (rowsCount == 1)
            //    {
            //        Console.WriteLine("注册成功");
            //    }
            //    else
            //    {
            //        Console.WriteLine("注册失败");
            //    }


            //}
            #endregion

            #region 登陆查询
            //Console.WriteLine("请输入用户名：");
            //string uname = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string upwd = Console.ReadLine();

            //using (MySqlConnection conn = new MySqlConnection(connStr))
            //{
            //    string sql = "select upwd from users1 where uname=@name";
            //    MySqlParameter pName = new MySqlParameter("@name",uname);

            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    cmd.Parameters.Add(pName);

            //    conn.Open();

            //    object upwd2 = cmd.ExecuteScalar();

            //    if (upwd2 == null)
            //    {
            //        Console.WriteLine("用户名错误");
            //    }
            //    else
            //    {
            //        if (upwd2.ToString().Equals(upwd))
            //        {
            //            Console.WriteLine("登陆成功");
            //        }
            //        else
            //        {
            //            Console.WriteLine("登陆失败");
            //        }
            //    }
            //}

            #endregion

            #region 修改
            //using (MySqlConnection conn = new MySqlConnection(connStr))
            //{
            //    string sql = "update users1 set uname='中国123' where id=9";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);

            //    conn.Open();

            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        Console.WriteLine("修改成功");
            //    }
            //    else
            //    {
            //        Console.WriteLine("修改失败");
            //    }
            //}

            #endregion

            #region 删除
            //using (MySqlConnection conn = new MySqlConnection(connStr))
            //{
            //    string sql = "delete from users1 where id=9";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    conn.Open();

            //    if (cmd.ExecuteNonQuery() > 0)
            //    {
            //        Console.WriteLine("成功");
            //    }
            //    else
            //    {
            //        Console.WriteLine("失败");
            //    }
            //}

            #endregion

            Console.ReadLine();
        }

        public static string connStr = "data source=localhost;database=mmorpg;user id=root;password=123456;pooling=false;charset=utf8;";
    }
}
