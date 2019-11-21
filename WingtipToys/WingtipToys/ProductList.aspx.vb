Imports System
Imports System.Linq
Imports System.Web.UI
Imports WingtipToys.Models
Imports System.Web.ModelBinding

Namespace WingtipToys
    Public Partial Class ProductList
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Public Function GetProducts(
<QueryString("id")> ByVal categoryId As Integer?) As IQueryable(Of Product)
            Dim _db = New WingtipToys.Models.ProductContext
            Dim query As IQueryable(Of Product) = _db.Products

            If categoryId.HasValue AndAlso categoryId > 0 Then
                query = query.Where(Function(p) p.CategoryID = categoryId)
            End If

            Return query
        End Function
    End Class
End Namespace
