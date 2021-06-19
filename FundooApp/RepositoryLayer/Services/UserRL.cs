using CommonLayer;
using RepositoryLayer.ContextDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Services
{
    public class UserRL
    {
        NotesContext _notesContext;
        public UserRL(NotesContext notesContext)
        {
            _notesContext = notesContext;
        }

        public void RegisterUser(User user)
        {
            try
            {
                _notesContext.Users.Add(user);
                _notesContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
