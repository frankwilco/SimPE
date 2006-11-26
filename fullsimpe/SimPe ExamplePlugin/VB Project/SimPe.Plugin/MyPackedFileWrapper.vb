Imports SimPe.Interfaces
Imports SimPe.Interfaces.Plugin
Imports SimPe.Interfaces.Plugin.Internal
Imports System
Imports System.IO

Namespace SimPe.Plugin
    Public Class MyPackedFileWrapper
        Inherits AbstractWrapper

        Implements IFileWrapper, IPackedFileWrapper, IWrapper, IPackedFileName, IDisposable, IFileWrapperSaveExtension, IPackedFileSaveExtension

        ' Methods
        Protected Overrides Function CreateDefaultUIHandler() As IPackedFileUI
            Return New MyPackedFileUI
        End Function

        Protected Overrides Function CreateWrapperInfo() As IWrapperInfo
            Return New AbstractWrapperInfo("Example Wrapper (Please Change!)", "Quaxi", "---", 2)
        End Function

        Protected Overrides Sub Serialize(ByVal writer As BinaryWriter)
        End Sub

        Protected Overrides Sub Unserialize(ByVal reader As BinaryReader)
            reader.BaseStream.Seek(CLng(23), SeekOrigin.Begin)
            Dim chArray1 As Char() = reader.ReadChars(10)
            Me.data = ""
            Dim ch1 As Char
            For Each ch1 In chArray1
                Me.data = (Me.data & ch1)
            Next
        End Sub

        Public ReadOnly Property AssignableTypes() As UInteger() Implements IFileWrapper.AssignableTypes
            Get
                Return New UInteger() {3959350082}
            End Get
        End Property
        

        Public Property Data() As String
            Get
                Return Me.m_data
            End Get
            Set(ByVal value As String)
                Me.m_data = value
            End Set
        End Property

        Public ReadOnly Property FileSignature() As Byte() Implements IFileWrapper.FileSignature
            Get
                Return New Byte(0 - 1) {}
            End Get
        End Property


        ' Fields
        Private m_data As String
    End Class
End Namespace


