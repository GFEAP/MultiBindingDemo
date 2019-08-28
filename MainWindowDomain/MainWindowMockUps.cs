using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBindingDemo.MainWindowDomain
{
    public static class MainWindowMockUps
    {

        public static MainWindowViewModel MainWindowViewModelMockUp
        {
            get
            {
                return new MainWindowViewModel()
                {
                    Text1 = "1",
                    Text2 = "2",
                    Text3 = "3",
                    Text4 = "4",
                    ScaleFactor = 2.0d
                };
            }
        }
    }
}