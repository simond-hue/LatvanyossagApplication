using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Port=3307;Database=latvanyossagokdb;Uid=root;Pwd=;");
            conn.Open();

            ListVarosok();
        }

        private void ListLatvanyossagok(int varosID)
        {
            try
            {
                listBoxLatvanyossagok.Items.Clear();

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT latvanyossagok.id, latvanyossagok.nev, leiras, ar, varos_id FROM latvanyossagok 
                                LEFT JOIN varosok ON latvanyossagok.varos_id = varosok.id
                                WHERE varos_id=@varos_id";
                cmd.Parameters.AddWithValue("@varos_id", varosID);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32("id");
                        var nev = reader.GetString("nev");
                        var leiras = reader.GetString("leiras");
                        var ar = reader.GetInt32("ar");
                        var varos_id = reader.GetInt32("varos_id");
                        listBoxLatvanyossagok.Items.Add(new Latvanyossag(id, nev, leiras, ar, varos_id));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Váratlan hiba történt!");
            }
        }

        private void ListVarosok()
        {
            listBoxVarosok.Items.Clear();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM varosok";
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                    listBoxVarosok.Items.Add(new Varos(id, nev, lakossag));
                }
            }
            latvanyossagVarosListazas();
        }

        private void latvanyossagVarosListazas()
        {
            listBoxLatvanyossagVarosa.Items.Clear();
            foreach(Varos varos in listBoxVarosok.Items)
            {
                listBoxLatvanyossagVarosa.Items.Add(varos);
            }
        }

        private void buttonVarosSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxVaros.Text == "" || textBoxVaros.Text == null)
                {
                    MessageBox.Show("Nem adott meg város nevet!");
                    return;
                }
                if (numericUpDownLakossag.Value <= 0)
                {
                    MessageBox.Show("Érvénytelen lakossági adat!");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO varosok (nev, lakossag)
                                VALUES(@nev, @lakossag)";
                cmd.Parameters.AddWithValue("@nev", textBoxVaros.Text);
                cmd.Parameters.AddWithValue("@lakossag", numericUpDownLakossag.Value);

                cmd.ExecuteNonQuery();

                ListVarosok();
            }
            catch(Exception ex)
            {
                if(ex.Message.ToLower().Contains("duplicate entry"))
                {
                    MessageBox.Show("A város már szerepel az adatbázisban!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonLatvanyossagHozzaad_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxLatvanyossag.Text == "" || textBoxLatvanyossag.Text == null)
                {
                    MessageBox.Show("Nem adta meg a látványosság nevét!");
                    return;
                }
                if(numericUpDownLatvanyossag.Value < 0)
                {
                    MessageBox.Show("Érvénytelen ár!");
                    return;
                }
                if(textBoxLatvanyossagLeiras.Text == "" || textBoxLatvanyossagLeiras.Text == null)
                {
                    MessageBox.Show("Üres leírás!");
                    return;
                }
                if(listBoxLatvanyossagVarosa.SelectedIndex == -1)
                {
                    MessageBox.Show("Nem választott ki várost");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO latvanyossagok 
                                        (nev, leiras, ar, varos_id)
                                  VALUES(@nev, @leiras, @ar, @varos_id)";
                cmd.Parameters.AddWithValue("@nev", textBoxLatvanyossag.Text);
                cmd.Parameters.AddWithValue("@leiras", textBoxLatvanyossagLeiras.Text);
                cmd.Parameters.AddWithValue("@ar", numericUpDownLatvanyossag.Value);
                cmd.Parameters.AddWithValue("@varos_id",((Varos)listBoxLatvanyossagVarosa.SelectedItem).Id);
                cmd.ExecuteNonQuery();

                if (listBoxVarosok.SelectedIndex != -1
                && listBoxLatvanyossagVarosa.SelectedIndex != -1
                && ((Varos)listBoxVarosok.SelectedItem).Id == ((Varos)listBoxLatvanyossagVarosa.SelectedItem).Id)
                    ListLatvanyossagok(((Varos)listBoxLatvanyossagVarosa.SelectedItem).Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Váratlan hiba történt!");
            }
        }

        private void buttonVarosDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxVarosok.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs kiválasztva város!");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM varosok WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", ((Varos)listBoxVarosok.SelectedItem).Id);

                cmd.ExecuteNonQuery();
                ListVarosok();
            }
            catch(Exception ex)
            {
                if(ex.Message.ToLower().Contains("foreign key constraint fails"))
                {
                    MessageBox.Show("Az elem nem törölhető, mert tartozik hozzá látványosság!");
                    return;
                }
                MessageBox.Show("Váratlan hiba történt!");
            }
        }

        private void listBoxVarosok_SelectedValueChanged(object sender, EventArgs e)
        {
            if(listBoxVarosok.SelectedIndex != -1)
            {
                textBoxEditVaros.Enabled = true;
                numericUpDownEditVaros.Enabled = true;
                ListLatvanyossagok(((Varos)listBoxVarosok.SelectedItem).Id);

                textBoxEditVaros.Text = ((Varos)listBoxVarosok.SelectedItem).Nev;
                numericUpDownEditVaros.Value = ((Varos)listBoxVarosok.SelectedItem).Lakossag;
            }
        }

        private void buttonVarosEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEditVaros.Text == "" || textBoxEditVaros.Text == null)
                {
                    MessageBox.Show("Nem adott meg város nevet!");
                    return;
                }
                if (numericUpDownEditVaros.Value <= 0)
                {
                    MessageBox.Show("Érvénytelen lakossági adat!");
                    return;
                }

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE varosok 
                                    SET nev = @nev, lakossag = @lakossag
                                    WHERE id = @id";
                cmd.Parameters.AddWithValue("@nev", textBoxEditVaros.Text);
                cmd.Parameters.AddWithValue("@lakossag", numericUpDownEditVaros.Value);
                cmd.Parameters.AddWithValue("@id", ((Varos)listBoxVarosok.SelectedItem).Id);

                cmd.ExecuteNonQuery();
                ListVarosok();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLatvanyossagDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxVarosok.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs kiválasztva város");
                    return;
                }
                if (listBoxLatvanyossagok.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs kiválasztva látványosság!");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM latvanyossagok WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", ((Latvanyossag)listBoxLatvanyossagok.SelectedItem).Id);

                cmd.ExecuteNonQuery();
                ListLatvanyossagok(((Varos)listBoxVarosok.SelectedItem).Id);
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("foreign key constraint fails"))
                {
                    MessageBox.Show("Az elem nem törölhető, mert tartozik hozzá látványosság!");
                    return;
                }
                MessageBox.Show("Váratlan hiba történt!");
            }
        }

        private void buttonLatvanyossagEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxVarosok.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs kiválasztva város!");
                    return;
                }
                if (listBoxLatvanyossagok.SelectedIndex == -1)
                {
                    MessageBox.Show("Nincs kiválasztva látványosság!");
                    return;
                }
                if (textBoxEditLatvanyossagNev.Text == "" || textBoxEditLatvanyossagNev.Text == null)
                {
                    MessageBox.Show("Nem adott meg látványosság nevet!");
                    return;
                }
                if (numericUpDownLatvanyossagAr.Value <= 0)
                {
                    MessageBox.Show("Érvénytelen ár!");
                    return;
                }

                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE latvanyossagok
                                    SET nev = @nev, ar = @ar, leiras = @leiras
                                    WHERE id = @id";
                cmd.Parameters.AddWithValue("@nev", textBoxEditLatvanyossagNev.Text);
                cmd.Parameters.AddWithValue("@ar", numericUpDownLatvanyossagAr.Value);
                cmd.Parameters.AddWithValue("@id", ((Latvanyossag)listBoxLatvanyossagok.SelectedItem).Id);
                cmd.Parameters.AddWithValue("@leiras", textBoxEditLatvanyossagLeiras.Text);

                cmd.ExecuteNonQuery();
                ListLatvanyossagok(((Varos)listBoxVarosok.SelectedItem).Id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxLatvanyossagok_SelectedValueChanged(object sender, EventArgs e)
        {
            if(listBoxLatvanyossagok.SelectedIndex != -1)
            {
                textBoxEditLatvanyossagNev.Enabled = true;
                numericUpDownLatvanyossagAr.Enabled = true;
                textBoxEditLatvanyossagLeiras.Enabled = true;

                textBoxEditLatvanyossagNev.Text = ((Latvanyossag)listBoxLatvanyossagok.SelectedItem).Nev;
                numericUpDownLatvanyossagAr.Value = ((Latvanyossag)listBoxLatvanyossagok.SelectedItem).Ar;
                textBoxEditLatvanyossagLeiras.Text = ((Latvanyossag)listBoxLatvanyossagok.SelectedItem).Leiras;
            }
        }
    }
}
