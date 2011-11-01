Option Explicit On
Option Strict On
Imports System
Imports System.IO

Module moveAllFromTo

    Sub Main()
        Dim FromPath As String = "P:\VB PROJECTS\Files\From\"
        Dim ToPath As String = "P:\VB PROJECTS\Files\To\"
        moveAllFiles(FromPath, ToPath)
    End Sub

    Sub moveAllFiles(ByVal FromPath As String, ByVal ToPath As String)
        If System.IO.Directory.Exists(FromPath) = True And System.IO.Directory.Exists(ToPath) = True Then
            For Each fName As String In
            System.IO.Directory.GetFiles(FromPath)
                System.IO.File.Move(fName, fName.Replace(FromPath, ToPath))
            Next
        End If
    End Sub
End Module