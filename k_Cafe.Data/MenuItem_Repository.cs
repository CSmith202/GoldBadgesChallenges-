using System.Runtime.CompilerServices;
using static System.Console;

public class MenuItem_Repository 
{
    private readonly List<MenuItem> _menuItemDb = new List<MenuItem>();
    private int _count;


   
    //create
    public bool AddMenuItem(MenuItem menuItem)
    {
        if (menuItem is null)
        {
            return false;
        }
        else
        {
            _count++;
            menuItem.Id = _count;
            _menuItemDb.Add(menuItem);
            return true;
        }
    }

    //read (all from db)
    public List<MenuItem> GetMenuItems()
    {
        return _menuItemDb;
    }

    //read by id (one)
    public MenuItem GetMenuItem(int menuItemId)
    {
        //look in the entire database
        foreach (MenuItem menuItem in _menuItemDb)
       {
            if(menuItem.Id == menuItemId)
            {
                return menuItem;
            }
       }
       return null;
    }

    //Update 
    public bool UpdateMenuItem(int id, MenuItem updatedMenuItem)
    {
        MenuItem menuItemInDb = GetMenuItem(id);
        if (menuItemInDb != null)
        {
            menuItemInDb.MealName= updatedMenuItem.MealName;
            menuItemInDb.Description = updatedMenuItem.Description;
            menuItemInDb.Ingredients = updatedMenuItem.Ingredients;
            menuItemInDb.Price = updatedMenuItem.Price;
            return true;
        }
        return false;
    }

    //Delete 
    public bool DeleteMenuItem(int id)
    {
        MenuItem menuItemInDb = GetMenuItem(id);
        return _menuItemDb.Remove(menuItemInDb);
    }
    }




