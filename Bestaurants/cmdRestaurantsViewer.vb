Imports System.Runtime.InteropServices
Imports System.Drawing
Imports ESRI.ArcGIS.ADF.BaseClasses
Imports ESRI.ArcGIS.ADF.CATIDs
Imports ESRI.ArcGIS.Framework
Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Carto

<ComClass(cmdRestaurantsViewer.ClassId, cmdRestaurantsViewer.InterfaceId, cmdRestaurantsViewer.EventsId), _
 ProgId("Bestaurants.cmdRestaurantsViewer")> _
Public NotInheritable Class cmdRestaurantsViewer
    Inherits BaseCommand

#Region "COM GUIDs"
    ' These  GUIDs provide the COM identity for this class 
    ' and its COM interfaces. If you change them, existing 
    ' clients will no longer be able to access the class.
    Public Const ClassId As String = "92910fee-bce1-441e-9e12-ff25e1c78b1a"
    Public Const InterfaceId As String = "f39bac1b-4a1e-4a0e-8a86-5f1c8d2a117e"
    Public Const EventsId As String = "4262f352-6f0b-454e-9985-613e0dabb127"
#End Region

#Region "COM Registration Function(s)"
    <ComRegisterFunction(), ComVisibleAttribute(False)> _
    Public Shared Sub RegisterFunction(ByVal registerType As Type)
        ' Required for ArcGIS Component Category Registrar support
        ArcGISCategoryRegistration(registerType)

        'Add any COM registration code after the ArcGISCategoryRegistration() call

    End Sub

    <ComUnregisterFunction(), ComVisibleAttribute(False)> _
    Public Shared Sub UnregisterFunction(ByVal registerType As Type)
        ' Required for ArcGIS Component Category Registrar support
        ArcGISCategoryUnregistration(registerType)

        'Add any COM unregistration code after the ArcGISCategoryUnregistration() call

    End Sub

#Region "ArcGIS Component Category Registrar generated code"
    Private Shared Sub ArcGISCategoryRegistration(ByVal registerType As Type)
        Dim regKey As String = String.Format("HKEY_CLASSES_ROOT\CLSID\{{{0}}}", registerType.GUID)
        MxCommands.Register(regKey)

    End Sub
    Private Shared Sub ArcGISCategoryUnregistration(ByVal registerType As Type)
        Dim regKey As String = String.Format("HKEY_CLASSES_ROOT\CLSID\{{{0}}}", registerType.GUID)
        MxCommands.Unregister(regKey)

    End Sub

#End Region
#End Region


    Private m_application As IApplication

    ' A creatable COM class must have a Public Sub New() 
    ' with no parameters, otherwise, the class will not be 
    ' registered in the COM registry and cannot be created 
    ' via CreateObject.
    Public Sub New()
        MyBase.New()

        ' TODO: Define values for the public properties
        MyBase.m_category = "Bestaurants_Tools"  'localizable text 
        MyBase.m_caption = "Resaurant Viewer"   'localizable text 
        MyBase.m_message = "View the restaurants in tabular format and interacts with the map"   'localizable text 
        MyBase.m_toolTip = "Restaurant viewer" 'localizable text 
        MyBase.m_name = "Bestaurants_Tools_RestaurantsViewer"  'unique id, non-localizable (e.g. "MyCategory_ArcMapCommand")

        Try
            'TODO: change bitmap name if necessary
            Dim bitmapResourceName As String = Me.GetType().Name + ".bmp"
            MyBase.m_bitmap = New Bitmap(Me.GetType(), bitmapResourceName)
        Catch ex As Exception
            System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap")
        End Try


    End Sub


    Public Overrides Sub OnCreate(ByVal hook As Object)
        If Not hook Is Nothing Then
            m_application = CType(hook, IApplication)

            'Disable if it is not ArcMap
            If TypeOf hook Is IMxApplication Then
                MyBase.m_enabled = True
            Else
                MyBase.m_enabled = False
            End If
        End If

        ' TODO:  Add other initialization code
    End Sub

    Public Overrides Sub OnClick()
        'TODO: Add cmdRestaurantsViewer.OnClick implementation
        Dim pRestaurantsViewer As New frmRestaurantsViewer

        pRestaurantsViewer.ArcMapApplication = m_application

        'show the form
        pRestaurantsViewer.Show()

        'Iapplication -> Imxdocument -> Imap ->Ilayer
        Dim pMxDoc As IMxDocument = m_application.Document
        'get the map from the document
        Dim pMap As IMap = pMxDoc.FocusMap
        'get the first layer
        'Dim pLayer As ILayer = pMap.Layer(0)
        'add the layer to the combo box
        'pRestaurantsViewer.cmbLayers.Items.Add(pLayer.Name)


        For i As Integer = 0 To pMap.LayerCount - 1
            Dim pLayer As ILayer = pMap.Layer(i)
            pRestaurantsViewer.cmbLayers.Items.Add(pLayer.Name)
        Next




    End Sub
End Class



