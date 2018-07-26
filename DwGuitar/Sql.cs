//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Text;
//using Newtonsoft.Json;


//namespace DwGuitar
//{

//    public class Archive
//    {
//        public string Code { get; set; }
//        public string Title { get; set; }
//        public string Author { get; set; }
//        public List<string> Category { get; set; }
//        public List<string> Imgs { get; set; }
//        public List<string> Tag { get; set; }
//    }

//    public class Author
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Avatar { get; set; }
//    }

//    public class Blog
//    {
//        public int Id { get; set; }
//        public string Code { get; set; }
//        public string Title { get; set; }
//        public int AuthorId { get; set; }
//    }


//    static class Program
//    {
//        /// <summary>
//        /// 应用程序的主入口点。
//        /// </summary>
//        //        [STAThread]
//        static void Main()
//        {
//            //            Application.EnableVisualStyles();
//            //            Application.SetCompatibleTextRenderingDefault(false);
//            //            Application.Run(new Form1());



//            var sr = new StreamReader(@"x:\users\wendy\documents\visual studio 2013\Projects\DwGuitar\DwGuitar\blog.json", Encoding.UTF8);
//            string json = sr.ReadToEnd();
//            sr.Close();

//            var connectionString = @"Data Source=(localdb)\mssqllocaldb; Initial Catalog=DwGuitar;User Id=sa;Password=123;";
//            var archives = JsonConvert.DeserializeObject<Archive[]>(json);

//            using (var conn = new SqlConnection(connectionString))
//            {
//                conn.Open();

//                DataTable blogDt = new DataTable();
//                new SqlDataAdapter("select Code from Blog",conn).Fill(blogDt);

//                var b = archives.Distinct(new A()).ToArray();

//                foreach (var item in b)
//                {
//                    int blogId = (int)new SqlCommand("select Id from Blog where Code='" + item.Code + "'", conn).ExecuteScalar();
//                    DataTable dt = new DataTable();
//                    new SqlDataAdapter("select Id from Tag where Name in('" + string.Join("','", item.Tag) + "')", conn).Fill(dt);

//                    foreach (DataRow row in dt.Rows)
//                    {
//                        var cmd = new SqlCommand("insert TagBlogRelation(BlogId, TagId) values(@BlogId, @TagId)", conn);
//                        cmd.Parameters.Add(new SqlParameter("@BlogId", blogId));
//                        cmd.Parameters.Add(new SqlParameter("@TagId", row["Id"]));
//                        cmd.ExecuteNonQuery();
//                    }
//                }
//            }
//        }


//    }

//    public class A : IEqualityComparer<Archive>
//    {
        

//        /// <summary>Determines whether the specified objects are equal.</summary>
//        /// <returns>true if the specified objects are equal; otherwise, false.</returns>
//        /// <param name="x">The first object of type <paramref name="T" /> to compare.</param>
//        /// <param name="y">The second object of type <paramref name="T" /> to compare.</param>
//        public bool Equals(Archive x, Archive y)
//        {
//            return x.Code == y.Code;
//        }

//        /// <summary>Returns a hash code for the specified object.</summary>
//        /// <returns>A hash code for the specified object.</returns>
//        /// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
//        /// <exception cref="T:System.ArgumentNullException">The type of <paramref name="obj" /> is a reference type and <paramref name="obj" /> is null.</exception>
//        public int GetHashCode(Archive obj)
//        {
//            return obj == null ? 0 : obj.ToString().GetHashCode();
//        }
//    }
//}
