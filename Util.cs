using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Sarasi_HMS
{
    class Util
    {
        private static String startLetter;
        private static int randomnumber;
        private static String key;
        private static bool result;

        public static String categoryID;
        private static FoodCategory fCategory;
        private static ItemCategory ICategory;



        private static List<FoodCategory> foodcategoriesID;
        private static List<ItemCategory> ItemcategoryIDs;
        private static List<Food> foodCodes;
        private static List<Item> itemIds;
        private static List<Employee> employeeIDs;
        private static List<StockAudit> stockAuditIds;
        private static List<VehicleCategory> vehiCategorylist; 
        private static List<Vehicle> vehicleIDS;
        private static List<Order_> orderIDS;


        //variables for limit checking
        private static int inCount;
        private static int outCount;
        private static int itemlimit;
        private static Item item;

        //method to generate a unique key 
        public static String generateKey(String tableName)
        {
            Random random = new Random(); 

            do
            {
                randomnumber = random.Next(0, 10000); //generateb random number 
                using (DBEntities db = new DBEntities())
                {
                    if (tableName == "FoodCategory")
                    {
                        startLetter = "Fc";
                        key = startLetter + randomnumber;
                        foodcategoriesID = db.FoodCategories.ToList();
                        result = foodcategoriesID.Exists(x => x.foodCategoryID.Contains(key));

                        

                    } else if (tableName == "ItemCategory_KtchenItem" || tableName == "ItemCategory_ReadyMade")
                    {
                        if (tableName == "ItemCategory_KtchenItem")
                        {
                            startLetter = "KIc";
                        } else if (tableName == "ItemCategory_ReadyMade")
                        {

                            startLetter = "RPc";
                        }

                        key = startLetter + randomnumber;
                        ItemcategoryIDs = db.ItemCategories.ToList();
                        result = ItemcategoryIDs.Exists(x => x.itemCategoryID.Contains(key));

                    } else if (tableName == "food")
                    {
                        startLetter = "F";
                        key = startLetter + randomnumber;
                        foodCodes = db.Foods.ToList();
                        result = foodCodes.Exists(x => x.foodCode.Contains(key));


                    }
                    else if (tableName == "readyMade")
                    {
                        startLetter = "RP";
                        key = startLetter + randomnumber;
                        itemIds = db.Items.ToList();
                        result = itemIds.Exists(x => x.itemID.Contains(key));

                    }else if (tableName == "driver" || tableName== "cleaner" || tableName== "receptionist" || tableName=="manager" || tableName=="headChef")
                    {
                        if (tableName == "driver")
                        {
                            startLetter = "D";
                        }else if (tableName == "cleaner")
                        {
                            startLetter = "C";
                        }
                        else if (tableName == "manager")
                        {
                            startLetter = "M";
                        }
                        else if (tableName == "headChef")
                        {
                            startLetter = "hc";
                        }
                        else if (tableName == "receptionist")
                        {
                            startLetter = "Rc";
                        }

                        key = startLetter + randomnumber;
                        employeeIDs = db.Employees.ToList();
                        result = employeeIDs.Exists(x => x.employeeId.Contains(key));
                    }
                    else if (tableName == "item")
                    {
                        startLetter = "I";
                        key = startLetter + randomnumber;
                        itemIds = db.Items.ToList();
                        result = itemIds.Exists(x => x.itemID.Contains(key));

                    }
                    else if (tableName == "stock")
                    {
                        startLetter = "SA";
                        key = startLetter + randomnumber;
                        stockAuditIds = db.StockAudits.ToList();
                        result = stockAuditIds.Exists(x => x.stockAuditID.Contains(key));

                    }
                    else if (tableName == "vehicleCategory")
                    {
                        startLetter = "Vc";
                        key = startLetter + randomnumber;
                        vehiCategorylist = db.VehicleCategories.ToList();
                        result = vehiCategorylist.Exists(x => x.vehicleCategoryID.Contains(key));

                    }
                    else if (tableName == "vehicle")
                    {
                        startLetter = "Veh";
                        key = startLetter + randomnumber;
                        vehicleIDS = db.Vehicles.ToList();
                        result = vehicleIDS.Exists(x => x.vehicleID.Contains(key));

                    }
                    else if (tableName == "orders")
                    {
                        startLetter = "or";
                        key = startLetter + randomnumber;
                        orderIDS = db.Order_.ToList();
                        result = orderIDS.Exists(x => x.orderID.Contains(key));

                    }

                }

            } while (result == true);
            return key;
        }//end of the generate key method 
    
        //method to get the selected categorie's id 
        public static String getCategoryID(String tableName, String categoryName)
        {
            using(DBEntities db = new DBEntities())
            {
                if (tableName == "FoodCategory")
                {
                    fCategory = db.FoodCategories.Where(fc => fc.name == categoryName).First();
                    categoryID = fCategory.foodCategoryID;
                }
                else if (tableName == "ItemCategory")
                {
                    ICategory = db.ItemCategories.Where(fc => fc.categoryName == categoryName).First();
                    categoryID = ICategory.itemCategoryID;
                }
            }

           
            return categoryID; ; //if not found 
        }// end of getCategory Function -------------------------------------------------


        //Method for convert an byte array to an image 
        public static Image convertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        //method to convert the image into an byte array
        public static byte[] convertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }


        //method to check the limit quaantity
        public static Boolean checkForLimitCross(String itemID)
        {
            item = new Item();
            using(DBEntities db = new DBEntities())
            {
                //getting the limit quantity 
                item = db.Items.Where(i => i.itemID == itemID).FirstOrDefault();
                itemlimit = (int)item.limitQuantity;
                inCount = (int)db.StockAudits.Where(t => t.inOut == true && t.itemID==itemID).Sum(i => i.quantity);

                try
                {
                    outCount = (int)db.StockAudits.Where(t => t.inOut == false && t.itemID == itemID).Sum(i => i.quantity);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message + "Add items to the stock before retrieving");
                }
              
            }

            if ((inCount - outCount) <= itemlimit)
            {
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.info;
                popup.TitleText = "Limit Exceeded!!!";             
                popup.TitleColor = Color.Red;
                popup.ContentText = item.name + " Quantity is getting low in the stock ";
                popup.ContentColor = Color.Black;

                popup.TitleFont = new System.Drawing.Font("Century", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                popup.ContentFont = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                popup.Popup();
                return false;
            }
            else if((inCount - outCount) == 0)
            {
                MessageBox.Show("No More " +item.name + " in the Stock!!!");
                return false;
            }
            else
            {
                MessageBox.Show("Not exceeded");
                return true;
            }            
        }


    }
}
