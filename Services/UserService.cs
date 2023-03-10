using DrinksWebApp.Data;
using DrinksWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using BC = BCrypt.Net.BCrypt;

namespace DrinksWebApp.Services
{
	public class UserService
	{
		public async Task<bool> Register(User user)
		{
            if (user.Name.Length == 0 || user.Password.Length == 0)
            {
                throw new BadHttpRequestException("Incorrect username or password");
            }

            using var context = new DrinksAppContext();
			var userNameExists = context.User.Any(u => u.Name == user.Name || 
													   u.Email == user.Email);

			if (userNameExists) 
			{
				return false;
			}

			user.Password = BC.HashPassword(user.Password);

			await context.AddAsync(user);
			await context.SaveChangesAsync();

			return true;
		}

		public async Task<User> Login(string username, string password)
		{
			using var context = new DrinksAppContext();
			var user = await context.User.Where(u => u.Name == username).FirstOrDefaultAsync();

			if (user == null) 
			{
				return null;
			}

			if( BC.Verify(password, user.Password))
			{
				return user;
			}
			return null;
		}

		public async Task<User> GetUserByName(string username)
		{
            using var context = new DrinksAppContext();
            return await context.User
				.Where(u => u.Name == username)
				.FirstOrDefaultAsync();
        }

		public async Task<ICollection<User>> GetUsersAsync()
		{
            using var context = new DrinksAppContext();
			return await context.User.ToListAsync();
        }

		public async Task UpdateUser(User user)
		{
			using var context = new DrinksAppContext();
			context.Update(user);
			await context.SaveChangesAsync();
		}

		public async Task<User> GetDetails(int userId)
		{
            using var context = new DrinksAppContext();
            return await context.User
                .Where(u => u.Id == userId)
                .FirstOrDefaultAsync();
        }
	}
}
