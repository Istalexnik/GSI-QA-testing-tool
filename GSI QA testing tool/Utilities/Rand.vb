Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace GSI_QA_testing_tool.Utilities
    Module Rand
        Function GenerateRandom(ByVal candidateChars As String, ByVal length As Integer) As String
            Dim randomString = New StringBuilder()
            Dim random = New Random()

            For i As Integer = 0 To length - 1
                randomString.Append(candidateChars(random.[Next](candidateChars.Length)))
            Next

            Return randomString.ToString()
        End Function
    End Module
End Namespace
