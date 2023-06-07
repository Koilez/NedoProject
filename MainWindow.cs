using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Project.methods;
using Project.model_data;
using System.DirectoryServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class MainWindow : Form
    {
        IMongoCollection<Person>? collection;
        bool filters = false;
        int pageNumber = 1;
        int pageSize = 3;
        int allPageNum;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string pathConnectionString = "mongodb://localhost:27017";

            MongoClient client = new MongoClient(pathConnectionString);
            IMongoDatabase database = client.GetDatabase("sandbox");

            collection = database.GetCollection<Person>("People");

            allPageNum = (int)Math.Ceiling((double)collection.Aggregate().ToList().Count() / 3);
            labelPages.Text = $"{pageNumber}/{allPageNum}";
        }

        private void buttonLook_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            enterCollection();
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            var newWindow = new WindowAddData(new Person());
            if (newWindow.ShowDialog() == DialogResult.OK)
            {
                Static_methods.AddDataToDB(collection, newWindow.person);
            }
        }

        private void buttonFilters_Click(object sender, EventArgs e)
        {
            if (!filters)
            {
                this.Width = 800;
                filters = !filters;
                groupBoxFilters.Visible = true;
            }
            else
            {
                this.Width = 700;
                filters = !filters;
                groupBoxFilters.Visible = false;
            }
        }

        private void enterCollection()
        {
            listViewData.Items.Clear();
            int numbers = 1;
            var filter = Builders<Person>.Filter.Empty;

            if (!string.IsNullOrEmpty(textBoxNameF.Text))
                filter &= Builders<Person>.Filter.Eq(p => p.FirstName, textBoxNameF.Text);

            if (!string.IsNullOrEmpty(textBoxSurF.Text))
                filter &= Builders<Person>.Filter.Eq(p => p.Lastname, textBoxSurF.Text);

            if (!string.IsNullOrEmpty(textBoxAgeF.Text) && int.TryParse(textBoxAgeF.Text, out int age))
                filter &= Builders<Person>.Filter.Eq(p => p.Age, age);

            if (!string.IsNullOrEmpty(textBoxCityF.Text))
                filter &= Builders<Person>.Filter.ElemMatch(p => p.AddressesList, a => a.City == textBoxCityF.Text);

            if (!string.IsNullOrEmpty(textBoxStreetF.Text))
                filter &= Builders<Person>.Filter.ElemMatch(p => p.AddressesList, a => a.Street == textBoxStreetF.Text);

            if (!string.IsNullOrEmpty(textBoxHouseF.Text) && int.TryParse(textBoxHouseF.Text, out int house))
                filter &= Builders<Person>.Filter.ElemMatch(p => p.AddressesList, a => a.HouseNumber == house);

            var result = collection.Aggregate()
                .Match(filter)
                .Skip((pageNumber - 1) * pageSize)
                .Limit(pageSize)
                .ToList();

            allPageNum = (int)Math.Ceiling((double)collection.Aggregate()
                .Match(filter)
                .ToList()
                .Count() / 3);

            labelPages.Text = $"{pageNumber}/{allPageNum}";

            foreach (var item in result)
            {
                ListViewItem itemView = new ListViewItem(item.Id);
                itemView.SubItems.Add($"{numbers++}) " + Static_methods.PersonData(item) + "\r\n");
                listViewData.Items.Add(itemView);
            }
        }




        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (pageNumber < allPageNum)
            {
                pageNumber++;
            }
            enterCollection();

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
            }
            enterCollection();

        }

        private void buttonUpEnd_Click(object sender, EventArgs e)
        {
            if (pageNumber < allPageNum)
            {
                pageNumber = allPageNum;
            }
            enterCollection();

        }

        private void buttonDownEnd_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber = 1;
            }
            enterCollection();

        }



        /*private void textBoxNameF_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxNameF.Text.Trim();
            if (input.Length > 0)
            {
                var filter = Builders<Person>.Filter.Regex(p => p.FirstName, new BsonRegularExpression($"^{input}", "i"));
                var distinctNames = collection.Distinct<string>("FirstName", filter).ToList();
                var autoCompleteSource = new AutoCompleteStringCollection();
                autoCompleteSource.AddRange(distinctNames.ToArray());
                textBoxNameF.AutoCompleteCustomSource = autoCompleteSource;
            }
            else
            {
                textBoxNameF.AutoCompleteCustomSource = null;
            }
        }*/


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNameF.Clear();
            textBoxSurF.Clear();
            textBoxAgeF.Clear();
            textBoxCityF.Clear();
            textBoxStreetF.Clear();
            textBoxHouseF.Clear();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listViewData.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewData.SelectedItems[0];

                string data = selectedItem.Text;

                var filter = Builders<Person>.Filter.Eq(p => p.Id, data);
                var result = collection.Aggregate().Match(filter).ToList().First();

                var newWindow = new WindowAddData(result);
                if (newWindow.ShowDialog() == DialogResult.OK)
                {
                    Static_methods.UpdateToDB(collection, result, newWindow.person);
                    enterCollection();
                }
            }
            else
            {
                MessageBox.Show("Enter data!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewData.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewData.SelectedItems[0];
                string data = selectedItem.Text;
                Static_methods.DeleteData(collection, data);
                enterCollection();
            }
            else
            {
                MessageBox.Show("Enter data!");
            }
        }
    }
}