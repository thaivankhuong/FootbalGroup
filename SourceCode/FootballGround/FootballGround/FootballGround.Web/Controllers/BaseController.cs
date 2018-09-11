using FootballGround.Common.MenuHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballGround.Web.Controllers
{
    public class BaseController : Controller
    {
        public List<MenuItem> Item { get; set; }
        public BaseController()
        {
            Item = new List<MenuItem>();
     
            List<MenuItem> ListItems = new List<MenuItem>
             {
                new MenuItem
                {
                    Title ="Products",
                    Icon ="glyphicon glyphicon-home",
                    Link ="#",
                    Childs = new List<MenuItem>
                    {
                       new MenuItem
                       {
                              Title ="Products",
                              Icon ="glyphicon glyphicon-home",
                              Link ="Admin/Article",
                       },
                       new MenuItem
                       {
                              Title ="Products1",
                              Icon ="glyphicon glyphicon-home",
                              Link ="Admin/Article",
                       },
                       new MenuItem
                       {
                              Title ="Products2",
                              Icon ="glyphicon glyphicon-home",
                              Link ="Admin/Article",
                              Childs  = new List<MenuItem>
                              {
                                  new MenuItem
                                  {
                                        Title ="Products2.2",
                                      Icon ="glyphicon glyphicon-home",
                                      Link ="Admin/Article",
                                  },
                                  new MenuItem
                                  {
                                        Title ="Products2.3",
                                      Icon ="glyphicon glyphicon-home",
                                      Link ="Admin/Article",
                                      Childs = new List<MenuItem>
                                      {
                                          new MenuItem
                                          {
                                                Title ="Home Index",
                                                  Icon ="glyphicon glyphicon-home",
                                                  Link ="Home/Index",
                                          },
                                          new MenuItem
                                          {
                                                Title ="Products2.3.1",
                                                  Icon ="glyphicon glyphicon-home",
                                                  Link ="Admin/Article",
                                          },
                                          new MenuItem
                                          {
                                                Title ="Products2.3.1",
                                                  Icon ="glyphicon glyphicon-home",
                                                  Link ="Admin/Article",
                                          }
                                      }
                                  },
                                  new MenuItem
                                  {
                                        Title ="Products2.3",
                                      Icon ="glyphicon glyphicon-home",
                                      Link ="Home/Contact",
                                  }
                              }
                       },
                       new MenuItem
                       {
                              Title ="Products3",
                              Icon ="glyphicon glyphicon-home",
                              Link ="Admin/Article",
                       }
                    }
                },
                new MenuItem
                {
                    Title ="User",
                    Icon ="glyphicon glyphicon-th-large",
                    Link ="Home/About",
                }
                          
            };
            Item.AddRange(ListItems);
        }
        public ActionResult _LeftMenu()
        {       
            return PartialView(Item);
        }

    }
}