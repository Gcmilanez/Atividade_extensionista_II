
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoSQL
{
    public partial class Form1 : Form
    {
        // ESTABELECER CONEXÃO COM O BANCO DE DADOS
        private MySqlConnection Conexao;
        private string data = "datasource=localhost;username=root;password=boot;database=Arquivos";


        // DESING DA TABELA
        public Form1()
        {
            InitializeComponent();
            listaBusca.View = View.Details;
            listaBusca.LabelEdit = true;
            listaBusca.AllowColumnReorder = true;
            listaBusca.FullRowSelect = true;
            listaBusca.GridLines = true;
            listaBusca.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listaBusca.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listaBusca.Columns.Add("Codigo", 100, HorizontalAlignment.Left);
            listaBusca.Columns.Add("Colecao", 150, HorizontalAlignment.Left);
            listaBusca.Columns.Add("Condicao", 100, HorizontalAlignment.Left);
            listaBusca.Columns.Add("Localizacao", 180, HorizontalAlignment.Left);
            listaBusca.Columns.Add("Funcionario", 150, HorizontalAlignment.Left);

        }

        private void Salvar_Click(object sender, EventArgs e)
        {

            try
            {
                // VARIÁVEIS DO ESCOPO DA FUNÇÃO
                string nome = textNome.Text;
                string codigo = textCodigo.Text;
                string colecao = textColecao.Text;
                string condicao = textCondicao.Text;
                string localizacao = textLocalizacao.Text;
                string funcionario = textFuncionario.Text;

                // Conexão com o banco de dados
                Conexao = new MySqlConnection(data);
                Conexao.Open();

                // CASO UM ELEMENTO NÃO FOR PREENCHIDO, DEVOLVER UM AVISO DE ERRO
                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(colecao) ||
                    string.IsNullOrEmpty(condicao) || string.IsNullOrEmpty(localizacao) || string.IsNullOrEmpty(funcionario))
                {
                    MessageBox.Show("Por favor, insira todas as informações do objeto.");
                }
                else
                {

                    string pesquisa = "SELECT * from informacoes WHERE codigo LIKE @codigo";
                    using (MySqlCommand verificacao = new MySqlCommand(pesquisa, Conexao))
                    {

                        // CASO O CÓDIGO INFORMADO JÁ ESTEJA ARMAZENADO NO BANCO DE DADOS, DEVOLVER UM AVISO DE ERRO
                        verificacao.Parameters.AddWithValue("@codigo", codigo);
                        int cont = Convert.ToInt32(verificacao.ExecuteScalar());

                        if (cont == 0)
                        {
                            string sql = "INSERT INTO informacoes (nome, codigo, colecao, condicao, localizacao, funcionario) " +
                                 "VALUES " +
                                 "('" + textNome.Text + "'," +
                                 "'" + textCodigo.Text + "'," +
                                 "'" + textColecao.Text + "'," +
                                 "'" + textCondicao.Text + "'," +
                                 "'" + textLocalizacao.Text + "'," +
                                 "'" + textFuncionario.Text + "') ";

                            // ARMAZENAR O ELEMENTO NO BANCO DE DADOS
                            MySqlCommand operacao = new MySqlCommand(sql, Conexao);
                            operacao.ExecuteReader();
                            MessageBox.Show("Objeto inserido com sucesso!");


                            // LIMPAR AS CAIXAS DE TEXTO
                            textNome.Clear();
                            textCodigo.Clear();
                            textColecao.Clear();
                            textCondicao.Clear();
                            textLocalizacao.Clear();
                            textFuncionario.Clear();


                        }
                        else MessageBox.Show("Já possui um objeto com este código, nenhuma alteração foi feita.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // FECHA A CONEXÃO
                Conexao.Close();
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                // VARIÁVEIS DO ESCOPO DA FUNÇÃO
                bool test = false;
                string busca_nome = textBuscaNome.Text;
                string busca_codigo = textBuscaCodigo.Text;
                string busca_colecao = textBuscaColecao.Text;

                // Conexão com o banco de dados
                Conexao = new MySqlConnection(data);
                Conexao.Open();

                // VERIFICA QUAL PARAMETRO SERÁ UTILIZADO PARA BUSCA
                string sql = "SELECT * from informacoes";
                if (!string.IsNullOrEmpty(busca_nome))
                {
                    sql += " WHERE nome LIKE " + "'%" + busca_nome + "%'";

                    if (!string.IsNullOrEmpty(busca_codigo))
                        sql += " AND codigo LIKE " + busca_codigo + "";

                    if (!string.IsNullOrEmpty(busca_colecao))
                        sql += " AND colecao LIKE " + "'%" + busca_colecao + "%'";

                }
                else

                    if (!string.IsNullOrEmpty(busca_codigo))
                {
                    sql += " WHERE codigo LIKE " + busca_codigo + "";
                    if (!string.IsNullOrEmpty(busca_colecao))
                        sql += " AND colecao LIKE " + "'%" + busca_colecao + "%'";

                }
                else

                        if (!string.IsNullOrEmpty(busca_colecao))
                    sql += " WHERE colecao LIKE " + "'%" + busca_colecao + "%'";

                else
                {
                    test = true;
                }

                if (test)
                {
                    MessageBox.Show("Erro, por favor, insira parâmetros para a busca.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (MySqlCommand verificacao = new MySqlCommand(sql, Conexao))
                    {

                        verificacao.Parameters.AddWithValue("@busca_nome", busca_nome);
                        verificacao.Parameters.AddWithValue("@busca_codigo", busca_codigo);
                        verificacao.Parameters.AddWithValue("@busca_coleca", busca_colecao);

                        int cont = Convert.ToInt32(verificacao.ExecuteScalar());

                        if (cont > 0)
                        {

                            MySqlCommand operacao = new MySqlCommand(sql, Conexao);
                            MySqlDataReader teclado = operacao.ExecuteReader();
                            listaBusca.Items.Clear();

                            while (teclado.Read())
                            {
                                string[] row =
                                {
                               teclado.GetString(0),
                               teclado.GetString(1),
                               teclado.GetString(2),
                               teclado.GetString(3),
                               teclado.GetString(4),
                               teclado.GetString(5),
                               teclado.GetString(6)
                            };

                                var linha_listaBusca = new ListViewItem(row);
                                listaBusca.Items.Add(linha_listaBusca);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum item foi encontrado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        // LISTAR TODAS INFORMAÇÃO DA TABELA DE INFORMAÇÕES
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Conexão com o banco de dados
                Conexao = new MySqlConnection(data);
                Conexao.Open();

                string sql = "SELECT * from informacoes";

                MySqlCommand operacao = new MySqlCommand(sql, Conexao);
                MySqlDataReader teclado = operacao.ExecuteReader();
                listaBusca.Items.Clear();

                while (teclado.Read())
                {
                    string[] row =
                    {
                        teclado.GetString(0),
                        teclado.GetString(1),
                        teclado.GetString(2),
                        teclado.GetString(3),
                        teclado.GetString(4),
                        teclado.GetString(5),
                        teclado.GetString(6)

                    };

                    var linha_listaBusca = new ListViewItem(row);
                    listaBusca.Items.Add(linha_listaBusca);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {

                string excluiNome = textExcluirNome.Text;
                string excluiCodigo = textExcluirCodigo.Text;
                Conexao = new MySqlConnection(data);
                Conexao.Open();

                string sql = "DELETE from informacoes";

                if (string.IsNullOrEmpty(excluiNome) && string.IsNullOrEmpty(excluiCodigo))
                {
                    MessageBox.Show("Erro, por favor, insira parâmetros para excluir o item.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!string.IsNullOrEmpty(excluiNome) && !string.IsNullOrEmpty(excluiCodigo))
                    {
                        sql += " WHERE nome LIKE @excluiNome AND codigo LIKE @excluiCodigo";
                        string pesquisa = "SELECT * from informacoes WHERE nome LIKE @excluiNome AND codigo LIKE @excluiCodigo";
                        using (MySqlCommand verificacao = new MySqlCommand(pesquisa, Conexao))
                        {

                            verificacao.Parameters.AddWithValue("@excluiNome", excluiNome);
                            verificacao.Parameters.AddWithValue("@excluiCodigo", excluiCodigo);
                            int cont = Convert.ToInt32(verificacao.ExecuteScalar());

                            if (cont > 0)
                            {
                                DialogResult result = MessageBox.Show("Tem certeza que deseja exlcuir este item?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (result == DialogResult.Yes)
                                {
                                    using MySqlCommand operacao = new MySqlCommand(sql, Conexao);
                                    {
                                        operacao.Parameters.AddWithValue("@excluiNome", "%" + excluiNome + "%");
                                        operacao.Parameters.AddWithValue("@excluiCodigo", excluiCodigo);
                                    }
                                    operacao.ExecuteReader();
                                    MessageBox.Show("Objeto excluido com sucesso!");
                                }
                            }
                            else MessageBox.Show("Objeto não foi encontrado no banco de dados.");
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(excluiNome))
                        {
                            sql += " WHERE nome LIKE @excluiNome";
                            string pesquisa = "SELECT * from informacoes WHERE nome LIKE @excluiNome";

                            using (MySqlCommand verificacao = new MySqlCommand(pesquisa, Conexao))
                            {

                                verificacao.Parameters.AddWithValue("@excluiNome", excluiNome);
                                int cont = Convert.ToInt32(verificacao.ExecuteScalar());

                                if (cont > 0)
                                {
                                    DialogResult result = MessageBox.Show("Tem certeza que deseja exlcuir este item?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                    if (result == DialogResult.Yes)
                                    {
                                        using MySqlCommand operacao = new MySqlCommand(sql, Conexao);
                                        {
                                            operacao.Parameters.AddWithValue("@excluiNome", "%" + excluiNome + "%");
                                        }
                                        operacao.ExecuteReader();
                                        MessageBox.Show("Objeto excluido com sucesso!");
                                    }
                                }
                                else MessageBox.Show("Objeto não foi encontrado no banco de dados.");
                            }
                        }

                        if (!string.IsNullOrEmpty(excluiCodigo))
                        {
                            sql += " WHERE codigo LIKE @excluiCodigo";
                            string pesquisa = "SELECT * from informacoes WHERE codigo LIKE @excluiCodigo";

                            using (MySqlCommand verificacao = new MySqlCommand(pesquisa, Conexao))
                            {

                                verificacao.Parameters.AddWithValue("@excluiCodigo", excluiCodigo);
                                int cont = Convert.ToInt32(verificacao.ExecuteScalar());

                                if (cont > 0)
                                {
                                    DialogResult result = MessageBox.Show("Tem certeza que deseja exlcuir este item?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                    if (result == DialogResult.Yes)
                                    {
                                        using MySqlCommand operacao = new MySqlCommand(sql, Conexao);
                                        {
                                            operacao.Parameters.AddWithValue("@excluiCodigo", excluiCodigo);
                                        }
                                        operacao.ExecuteReader();
                                        MessageBox.Show("Objeto excluido com sucesso!");
                                    }
                                }
                                else MessageBox.Show("Objeto não foi encontrado no banco de dados.");
                            }
                        }

                    }
                }

                textExcluirNome.Clear();
                textExcluirCodigo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            try
            {

                string alteraNome = textNome.Text;
                string alteraCodigo = textCodigo.Text;
                string alteraColecao = textColecao.Text;
                string alteraCondicao = textCondicao.Text;
                string alteraLocalizacao = textLocalizacao.Text;
                string alteraFuncionario = textFuncionario.Text;

                Conexao = new MySqlConnection(data);
                Conexao.Open();

                if (string.IsNullOrEmpty(alteraCodigo))
                {
                    MessageBox.Show("Por favor, insira o código do item para alterá-lo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string Atualizacao = "UPDATE informacoes SET ";

                    if (!string.IsNullOrEmpty(alteraNome))
                        Atualizacao += "nome=@alteraNome, ";

                    if (!string.IsNullOrEmpty(alteraColecao))
                        Atualizacao += "colecao=@alteraColecao, ";

                    if (!string.IsNullOrEmpty(alteraCondicao))
                        Atualizacao += "condicao=@alteraCondicao, ";

                    if (!string.IsNullOrEmpty(alteraLocalizacao))
                        Atualizacao += "localizacao=@alteraLocalizacao, ";

                    if (!string.IsNullOrEmpty(alteraFuncionario))
                        Atualizacao += "funcionario=@alteraFuncionario, ";

                    if (Atualizacao.EndsWith(", "))
                    {
                        Atualizacao = Atualizacao.Remove(Atualizacao.Length - 2);
                    }
                    Atualizacao += " WHERE codigo = @alteraCodigo";
                    string pesquisa = "SELECT COUNT(*) FROM informacoes WHERE codigo = @alteraCodigo";
                    using (MySqlCommand verificacao = new MySqlCommand(pesquisa, Conexao))
                    {
                        verificacao.Parameters.AddWithValue("@alteraCodigo", alteraCodigo);
                        int cont = Convert.ToInt32(verificacao.ExecuteScalar());

                        if (cont > 0)
                        {
                            if (string.IsNullOrEmpty(alteraNome) && string.IsNullOrEmpty(alteraColecao) && string.IsNullOrEmpty(alteraCondicao) && string.IsNullOrEmpty(alteraLocalizacao) && string.IsNullOrEmpty(alteraFuncionario))
                            {
                                MessageBox.Show("Por favor, insira algum elemento para a alteração.");
                            }
                            else
                            {
                                DialogResult resultado = MessageBox.Show("Deseja alterar este item?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (resultado == DialogResult.Yes)
                                {
                                    using MySqlCommand operacao = new MySqlCommand(Atualizacao, Conexao);
                                    operacao.Parameters.AddWithValue("@alteraCodigo", alteraCodigo);
                                    if (!string.IsNullOrEmpty(alteraNome))
                                    {
                                        operacao.Parameters.AddWithValue("@alteraNome", alteraNome);
                                    }

                                    if (!string.IsNullOrEmpty(alteraColecao))
                                    {
                                        operacao.Parameters.AddWithValue("@alteraColecao", alteraColecao);
                                    }

                                    if (!string.IsNullOrEmpty(alteraCondicao))
                                    {
                                        operacao.Parameters.AddWithValue("@alteraCondicao", alteraCondicao);
                                    }

                                    if (!string.IsNullOrEmpty(alteraLocalizacao))
                                    {
                                        operacao.Parameters.AddWithValue("@alteraLocalizacao", alteraLocalizacao);
                                    }

                                    if (!string.IsNullOrEmpty(alteraFuncionario))
                                    {
                                        operacao.Parameters.AddWithValue("@alteraFuncionario", alteraFuncionario);
                                    }
                                    operacao.ExecuteNonQuery();
                                    MessageBox.Show("Objeto alterado com sucesso!");
                                    textNome.Clear();
                                    textCodigo.Clear();
                                    textColecao.Clear();
                                    textCondicao.Clear();
                                    textLocalizacao.Clear();
                                    textFuncionario.Clear();

                                }
                            }
                        }
                        else MessageBox.Show("Codigo do elemento não foi encontrado, nenhuma alteração foi feita.");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
