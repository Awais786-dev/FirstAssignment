namespace FirstAssignment.Models
{
    public class UserRepos
    {
       // List<User> users;
        private List<User> users;
        public UserRepos()
        {
                users = new List<User>()  {
                new User() { Id=1, Name="M Awais" , Age=21 },
                new User() { Id=2, Name="Ali Khan" , Age=27 },
                new User() { Id=3,  Name="Tahir Mustasfvi" , Age=20 },
                new User() { Id=4,  Name="Abdullah" , Age=23 }

            };
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(int id)
        {     
            return users.Find(s=> s.Id == id);
        }

        public void AddNewUser(User user)
        {
            users.Add(user);
            
            // Check if the user can be retrieved by ID
            //var addedUserCheck = GetUserById(u.Id);

            //if (addedUserCheck != null)
            //{
            //    Console.WriteLine($"User with ID {u.Id} was successfully added.");
            //}
            //else
            //{
            //    Console.WriteLine($"User with ID {u.Id} was not added.");
            //}

        }


        public void UpdateUser(int id, User updatedUser)
        {
            User existingUser = GetUserById(id);
            if (existingUser != null)
            {
                existingUser.Name = updatedUser.Name;
                existingUser.Age = updatedUser.Age;            
            }
            else
            {
                throw new Exception("User not found.");
            }
        }

            public void DeleteUser(int id)
            {
                User userToRemove = GetUserById(id);
                if (userToRemove != null)
                {
                    users.Remove(userToRemove);
                }
                else
                {
                    throw new Exception("User not found.");
                }
            }
        


        public void DeleteUserAndCheck(int id)
        {
            // Attempt to delete the user
            DeleteUser(id);

            // Check if the user still exists
            var deletedUser = GetUserById(id);

            if (deletedUser == null)
            {
                Console.WriteLine($"User with ID {id} was successfully deleted.");
            }
            else
            {
                Console.WriteLine($"User with ID {id} was not deleted.");
            }
        }



    }
}
