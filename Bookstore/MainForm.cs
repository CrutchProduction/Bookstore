using System.Security.Cryptography.X509Certificates;
using ClassLibraryBookstore;

namespace Bookstore
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            new MyClassLibrary(panelNewBook, panelStore, buttonNewBook, labelNameBook, buttonStore, textBoxGenre, labelGenre, textBoxAuthor, labelAuthor, textBoxNameBook, labelPages, textBoxPrice, labelPrice, textBoxPages, label_idBook, textBoxIDBook, labelRUB, buttonRandom, buttonAddBook, labelErrors, labelBalance, labelRUBL, textBoxBalance, labelFindBook, textBoxFindBook, buttonCloset1, buttonCloset5, buttonCloset4, buttonCloset3, buttonCloset2, buttonCloset11, buttonCloset10, buttonCloset9, buttonCloset8, buttonCloset7, buttonCloset6, panelBookInfo, label_panel_id, label_panel_namebook, listBoxID, listBoxNameBook, label_panel_author, label_panel_pages, listBoxAuthor, listBoxPrice, label_panel_price, listBoxPages, buttonSellBook);
        }
    }
}
