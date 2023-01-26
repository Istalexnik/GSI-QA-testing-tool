
Imports System.Data
Imports System.Data.SqlClient

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString

    Protected Sub saveUser_Click(sender As Object, e As EventArgs) Handles saveUser.Click
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("INSERT INTO users(firstname, lastname) VALUES (@firstName, @lastName)")
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@firstName", firstName.Text)
                cmd.Parameters.AddWithValue("@lastName", lastName.Text)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()

                cmd.CommandText = "SELECT firstname, lastname, createdate FROM users"
                GridView1.DataSource = cmd.ExecuteReader()
                GridView1.DataBind()
                con.Close()
            End Using
        End Using
    End Sub

    Protected Sub loadUsers_Click(sender As Object, e As EventArgs) Handles loadUsers.Click
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("SELECT firstname, lastname FROM users")
                cmd.CommandType = CommandType.Text
                cmd.Connection = con
                con.Open()
                GridView1.DataSource = cmd.ExecuteReader()
                GridView1.DataBind()
                con.Close()

            End Using
        End Using
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Using con As New SqlConnection(constr)
                Using cmd As New SqlCommand("SELECT firstname, lastname, createdate FROM users")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    GridView1.DataSource = cmd.ExecuteReader()
                    GridView1.DataBind()
                    con.Close()

                End Using
            End Using
        End If
    End Sub
End Class

