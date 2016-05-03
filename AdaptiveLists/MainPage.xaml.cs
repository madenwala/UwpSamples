using System.Diagnostics;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdaptiveLists
{
    public class ListItem
    {
        public int Index { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return this.Description;
        }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            list.ItemsSource = Enumerable.Range(0, 100).Select(i => new ListItem
            {
                Index = i,
                ImageURL = "Assets/Water.jpg",
                Description = $"Item {i}"
            }).ToList();

            //ImageURL = "http://3.bp.blogspot.com/-fyjvPBm_INs/ThpaZFszL5I/AAAAAAAAAFw/6sJBTUj905c/s1600/water_drop.jpg",
        }

        private void list_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as ListItem;
            Debug.WriteLine(item.Index.ToString());
        }
    }
}
