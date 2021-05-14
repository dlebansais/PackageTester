namespace PackageTester
{
    using System.IO;
    using System.Windows;
    using Contracts;
    using Easly;
    using EaslyNumber;
    using PolySerializer;

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

            Contract.RequireNotNull(Name, out string WindowName);
            MpfrDotNet.mpfr_t HugeDouble = new();
            string ValueString = HugeDouble.ToString();
            Number N = Number.Zero;
            ValueString = N.ToString();

            Serializer NewSerializer = new Serializer();
            MemoryStream Stream = new MemoryStream();
            NewSerializer.Serialize(Stream, ValueString);

            System.Reflection.PropertyInfo Info = typeof(MainWindow).GetProperty("Name")!;
            PropertyEntity NewE = new(Info);
        }

        /// <summary>
        /// Gets a value indicating whether the window should be hidden.
        /// </summary>
        public bool HideMe { get; } = false;
    }
}
