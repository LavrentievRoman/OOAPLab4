using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public interface IRecommendationPlugin
    {
        List<string> GetRecommendations(List<string> userHistory, List<Product> product);
    }

    public class PopularProductsRecommendationPlugin : IRecommendationPlugin 
    {
        public List<string> GetRecommendations(List<string> userHistory, List<Product> product)
        {
            Product best1 = product[0], best2 = product[1], best3 = product[2];
            int max1 = 0, max2 = 0, max3 = 0;

            for (int i = 0; i < product.Count; i++)
            {
                if (product[i].sale >= max1)
                {
                    max3 = max2; max2 = max1; max1 = product[i].sale;
                    best3 = best2; best2 = best1; best1 = product[i];
                }
                else
                {
                    if (product[i].sale >= max2)
                    {
                        max3 = max2; max2 = product[i].sale;
                        best3 = best2; best2 = product[i];
                    }
                    else
                    {
                        if (product[i].sale >= max3)
                        {
                            max3 = product[i].sale;
                            best3 = product[i];
                        }
                    }
                }
            }

            return new List<string> { best1.type + ": " + best1.name, best2.type + ": " + best2.name, best3.type + ": " + best3.name };
        }
    }

    public class UserHistoryRecommendationPlugin : IRecommendationPlugin
    {
        public List<string> GetRecommendations(List<string> userHistory, List<Product> product)
        {
            int monitor = 0, keyboard = 0, mouse = 0;

            for (int i =  0; i < userHistory.Count; i++)
            {
                Product prod = product.Find(p => p.name == userHistory[i]);
                if (prod.type == "Monitor") monitor++;
                if (prod.type == "Keyboard") keyboard++;
                if (prod.type == "Mouse") mouse++;
            }

            Product best1 = product[0], best2 = product[1], best3 = product[2];
            int max1 = 0, max2 = 0, max3 = 0;

            if (monitor >= keyboard && monitor >= mouse)
            {
                for (int i = 0; i < product.Count; i++)
                {
                    if (product[i].sale >= max1 && product[i].type == "Monitor")
                    {
                        max3 = max2; max2 = max1; max1 = product[i].sale;
                        best3 = best2; best2 = best1; best1 = product[i];
                    }
                    else
                    {
                        if (product[i].sale >= max2 && product[i].type == "Monitor")
                        {
                            max3 = max2; max2 = product[i].sale;
                            best3 = best2; best2 = product[i];
                        }
                        else
                        {
                            if (product[i].sale >= max3 && product[i].type == "Monitor") 
                            {
                                max3 = product[i].sale;
                                best3 = product[i];
                            }
                        }
                    }
                }
            }
            else if (keyboard >= monitor && keyboard >= mouse)
            {
                for (int i = 0; i < product.Count; i++)
                {
                    if (product[i].sale >= max1 && product[i].type == "Keyboard")
                    {
                        max3 = max2; max2 = max1; max1 = product[i].sale;
                        best3 = best2; best2 = best1; best1 = product[i];
                    }
                    else
                    {
                        if (product[i].sale >= max2 && product[i].type == "Keyboard")
                        {
                            max3 = max2; max2 = product[i].sale;
                            best3 = best2; best2 = product[i];
                        }
                        else
                        {
                            if (product[i].sale >= max3 && product[i].type == "Keyboard")
                            {
                                max3 = product[i].sale;
                                best3 = product[i];
                            }
                        }
                    }
                }
            }
            else if (mouse >= monitor && mouse >= keyboard)
            {
                for (int i = 0; i < product.Count; i++)
                {
                    if (product[i].sale >= max1 && product[i].type == "Mouse")
                    {
                        max3 = max2; max2 = max1; max1 = product[i].sale;
                        best3 = best2; best2 = best1; best1 = product[i];
                    }
                    else
                    {
                        if (product[i].sale >= max2 && product[i].type == "Mouse")
                        {
                            max3 = max2; max2 = product[i].sale;
                            best3 = best2; best2 = product[i];
                        }
                        else
                        {
                            if (product[i].sale >= max3 && product[i].type == "Mouse")
                            {
                                max3 = product[i].sale;
                                best3 = product[i];
                            }
                        }
                    }
                }
            }

            return new List<string> { best1.type + ": " + best1.name, best2.type + ": " + best2.name, best3.type + ": " + best3.name };
        }
    }

    public class RecommendationManager
    {
        private List<IRecommendationPlugin> recommendationPlugins = new List<IRecommendationPlugin>();

        public void AddRecommendationPlugin(IRecommendationPlugin plugin)
        {
            recommendationPlugins.Add(plugin);
        }

        public void RemoveRecommendationPlugin(IRecommendationPlugin plugin)
        {
            recommendationPlugins.Remove(plugin);
        }

        public List<string> GetRecommendations(List<string> userHistory, List<Product> product)
        {
            List<string> recommendations = new List<string>();
            foreach (var plugin in recommendationPlugins)
            {
                recommendations.AddRange(plugin.GetRecommendations(userHistory, product));
            }
            return recommendations;
        }
    }
}
