namespace PackageTester
{
    using System.Globalization;
    using System.Windows;
    using System.Windows.Data;
    using CustomControls;

    /// <summary>
    /// The window class.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        /// <summary>
        /// Gets a value indicating whether the window should be hidden.
        /// </summary>
        public bool HideMe { get; } = false;
    }
}
