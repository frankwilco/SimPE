Imports SimPe.Events
Imports SimPe.Interfaces
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace SimPe.Plugin
    Public Class MyWindowPlugin
        Implements IToolPlus, IToolExt, IToolPlugin

        ' Methods
        Public Function ChangeEnabledStateEventHandler(ByVal sender As Object, ByVal e As ResourceEventArgs) As Boolean Implements IToolPlus.ChangeEnabledStateEventHandler
            Return True
        End Function

        Public Sub Execute(ByVal sender As Object, ByVal e As ResourceEventArgs) Implements IToolPlus.Execute
            If Me.ChangeEnabledStateEventHandler(sender, e) Then
                Dim form1 As New MyWindowPluginForm
                form1.ShowDialog()
                form1.Dispose()
            End If
        End Sub

        Public Overrides Function ToString() As String Implements IToolPlugin.ToString
            Return "Object Creation\Example Plugin"
        End Function


        ' Properties
        Public ReadOnly Property Icon() As Image Implements IToolExt.Icon
            Get
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property Shortcut() As Shortcut Implements IToolExt.Shortcut
            Get
                Return Shortcut.None
            End Get
        End Property

        Public ReadOnly Property Visible() As Boolean Implements IToolExt.Visible
            Get
                Return True
            End Get
        End Property

    End Class
End Namespace


