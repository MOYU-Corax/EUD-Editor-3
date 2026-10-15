Imports System.Globalization

Public Class EMailValidationRule
    Inherits ValidationRule

    Private AbleConst As String = ".@0123456789abcdefghijklnmopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Public Overrides Function Validate(value As Object, cultureInfo As CultureInfo) As ValidationResult
        '일단 숫자인지 아닌지 판단.
        Dim str As String = value

        If str Is Nothing Then
            Return New ValidationResult(False, "值不能为空。")
        End If
        If str = "" Then
            Return New ValidationResult(False, "值不能为空。")
        End If
        If str.Length > 40 Then
            Return New ValidationResult(False, "请输入 40 字以内。")
        End If

        If str.IndexOf("@") = -1 Then
            Return New ValidationResult(False, "电子邮箱格式不正确。")
        End If
        If str.IndexOf("@") <> str.LastIndexOf("@") Then
            Return New ValidationResult(False, "电子邮箱格式不正确。")
        End If


        If str.IndexOf(".") = -1 Then
            Return New ValidationResult(False, "电子邮箱格式不正确。")
        End If
        If str.IndexOf(".") <> str.LastIndexOf(".") Then
            Return New ValidationResult(False, "电子邮箱格式不正确。")
        End If


        If str.IndexOf("@") > str.IndexOf(".") Then
            Return New ValidationResult(False, "电子邮箱格式不正确。")
        End If

        For i = 0 To str.Length - 1
            If AbleConst.IndexOf(str(i)) = -1 Then
                Return New ValidationResult(False, "只能输入字母和数字。")
            End If
        Next

        Return ValidationResult.ValidResult


    End Function


End Class
