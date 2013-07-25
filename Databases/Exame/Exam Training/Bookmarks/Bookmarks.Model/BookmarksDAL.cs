using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bookmarks.Model
{
    public class BookmarksDAL
    {

        public static void AddBookmark(string username, string title, string url, string[] tags, string notes, string name, string password)
        {
            BookmarksEntities context = new BookmarksEntities();
            Bookmark newBookmark = new Bookmark();

            newBookmark.User = CreateOrLoadUser(context, username, name, password);
            newBookmark.Title = title;
            newBookmark.URL = url;
            newBookmark.Note = notes;

            foreach (var tagName in tags)
            {
                Tag tag = CreateOrLoadTag(context, tagName);
                newBookmark.Tags.Add(tag);
            }


            context.Bookmarks.Add(newBookmark);

            string[] titleTags = Regex.Split(title, @"[,'!\. ;?-]+");

            foreach (var titleToTagName in titleTags)
            {
                Tag titleTag = CreateOrLoadTag(context, titleToTagName);
                newBookmark.Tags.Add(titleTag);
            }
            context.SaveChanges();


        }

        private static Tag CreateOrLoadTag(BookmarksEntities context, string tagName)
        {
            Tag existingTag =
                 (from t in context.Tags
                  where t.Name == tagName.ToLower()
                  select t).FirstOrDefault();

            if (existingTag != null)
            {
                return existingTag;
            }

            Tag newTag = new Tag();
            newTag.Name = tagName.ToLower();
            context.Tags.Add(newTag);


            return newTag;
        }

        private static User CreateOrLoadUser(BookmarksEntities context, string username, string name, string password)
        {

            User existingUser = (from u in context.Users
                                 where u.Username == username.ToLower()
                                 select u).FirstOrDefault();

            if (existingUser != null)
            {
                return existingUser;
            }

           
            if (password != null)
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                var passwordHash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
                password = passwordHash.ToString();
            }
           
            User newUser = new User();
            newUser.Username = username.ToLower();
            newUser.Name = name;
            newUser.Password = password;
            context.Users.Add(newUser);
            context.SaveChanges();

            return newUser;
        }
    }
}
