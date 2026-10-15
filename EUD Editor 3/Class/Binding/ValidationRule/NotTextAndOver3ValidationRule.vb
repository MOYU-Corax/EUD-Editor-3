Imports System.Globalization

Public Class NotTextAndOver3ValidationRule
    Inherits ValidationRule

    Public Overrides Function Validate(value As Object, cultureInfo As CultureInfo) As ValidationResult
        '일단 숫자인지 아닌지 판단.
        Try
            Dim number As Long = value

            If number < 3 Then
                Return New ValidationResult(False, "请输入大于 3 的数字。")
            End If

            Return ValidationResult.ValidResult
        Catch ex As Exception
            Return New ValidationResult(False, "请输入数字")
            'Return New ValidationResult(False, value.ToString)
        End Try


    End Function
End Class
