using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KDA.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Grid에 마우스 이벤트 핸들러 추가 (창 드래그 기능)
            this.MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
        }

        // 창 드래그
        private void MainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // 마우스 클릭 위치가 버튼이 아닐 때만 창을 드래그 가능
            if (e.LeftButton == MouseButtonState.Pressed
                && e.OriginalSource is not System.Windows.Controls.Button)
            {
                this.DragMove();
            }
        }
    }
}