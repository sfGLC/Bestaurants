Imports System.Runtime.InteropServices

<ComClass(Class1.ClassId, Class1.InterfaceId, Class1.EventsId), _
 ProgId("Bestaurants.Class1")> _
Public Class Class1

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "dc7d9dae-4f0b-4967-844b-8f498ee72f75"
    Public Const InterfaceId As String = "345e60e3-f2d5-45bd-92f8-5afb4cd3ee33"
    Public Const EventsId As String = "9b0d4714-07cf-4c90-9f8d-d6d789ebae3d"
#End Region

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()
    End Sub

End Class


