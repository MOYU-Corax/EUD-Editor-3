Imports System.Globalization

Public Class TextValidationRule
    Inherits ValidationRule
    Private notAbleConst As String = "\/:*?""'<>|"
    Public Overrides Function Validate(value As Object, cultureInfo As CultureInfo) As ValidationResult
        Dim str As String = value

        If str Is Nothing Then
            Return New ValidationResult(False, "值不能为空。")
        End If
        If str = "" Then
            Return New ValidationResult(False, "值不能为空。")
        End If
        If str.Length > 100 Then
            Return New ValidationResult(False, "请输入 20 字以内。")
        End If


        For i = 0 To str.Length - 1
            If notAbleConst.IndexOf(str(i)) >= 0 Then
                Return New ValidationResult(False, "\ / : * ? "" ' < > |  不能输入以上字符")
            End If
        Next

        Return ValidationResult.ValidResult
    End Function
End Class
