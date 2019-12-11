using GeeDemos.MultiBinding.ViewModels;

namespace GeeDemos.MultiBinding.DataMockups
{
    public static class MainWindowMockUps
    {
        public static MainViewModel MainViewModelMockUp
        {
            get
            {
                return new MainViewModel()
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