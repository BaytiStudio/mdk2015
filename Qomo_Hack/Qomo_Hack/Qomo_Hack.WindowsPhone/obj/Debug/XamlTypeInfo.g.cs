﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Qomo_Hack
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[13];
            _typeNameTable[0] = "Qomo_Hack.HubPage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "Qomo_Hack.Common.NavigationHelper";
            _typeNameTable[4] = "Windows.UI.Xaml.DependencyObject";
            _typeNameTable[5] = "Qomo_Hack.Common.ObservableDictionary";
            _typeNameTable[6] = "Object";
            _typeNameTable[7] = "String";
            _typeNameTable[8] = "Qomo_Hack.Lapor";
            _typeNameTable[9] = "Qomo_Hack.Login";
            _typeNameTable[10] = "Qomo_Hack.SectionPage";
            _typeNameTable[11] = "Qomo_Hack.ItemPage";
            _typeNameTable[12] = "Qomo_Hack.Signup";

            _typeTable = new global::System.Type[13];
            _typeTable[0] = typeof(global::Qomo_Hack.HubPage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::Qomo_Hack.Common.NavigationHelper);
            _typeTable[4] = typeof(global::Windows.UI.Xaml.DependencyObject);
            _typeTable[5] = typeof(global::Qomo_Hack.Common.ObservableDictionary);
            _typeTable[6] = typeof(global::System.Object);
            _typeTable[7] = typeof(global::System.String);
            _typeTable[8] = typeof(global::Qomo_Hack.Lapor);
            _typeTable[9] = typeof(global::Qomo_Hack.Login);
            _typeTable[10] = typeof(global::Qomo_Hack.SectionPage);
            _typeTable[11] = typeof(global::Qomo_Hack.ItemPage);
            _typeTable[12] = typeof(global::Qomo_Hack.Signup);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_HubPage() { return new global::Qomo_Hack.HubPage(); }
        private object Activate_5_ObservableDictionary() { return new global::Qomo_Hack.Common.ObservableDictionary(); }
        private object Activate_8_Lapor() { return new global::Qomo_Hack.Lapor(); }
        private object Activate_9_Login() { return new global::Qomo_Hack.Login(); }
        private object Activate_10_SectionPage() { return new global::Qomo_Hack.SectionPage(); }
        private object Activate_11_ItemPage() { return new global::Qomo_Hack.ItemPage(); }
        private object Activate_12_Signup() { return new global::Qomo_Hack.Signup(); }
        private void MapAdd_5_ObservableDictionary(object instance, object key, object item)
        {
            var collection = (global::System.Collections.Generic.IDictionary<global::System.String, global::System.Object>)instance;
            var newKey = (global::System.String)key;
            var newItem = (global::System.Object)item;
            collection.Add(newKey, newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Qomo_Hack.HubPage
                userType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_HubPage;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Qomo_Hack.Common.NavigationHelper
                userType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  Windows.UI.Xaml.DependencyObject
                xamlType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  Qomo_Hack.Common.ObservableDictionary
                userType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.DictionaryAdd = MapAdd_5_ObservableDictionary;
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  Object
                xamlType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  String
                xamlType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  Qomo_Hack.Lapor
                userType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_Lapor;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Qomo_Hack.Login
                userType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_Login;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  Qomo_Hack.SectionPage
                userType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_SectionPage;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  Qomo_Hack.ItemPage
                userType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_ItemPage;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  Qomo_Hack.Signup
                userType = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_Signup;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_HubPage_NavigationHelper(object instance)
        {
            var that = (global::Qomo_Hack.HubPage)instance;
            return that.NavigationHelper;
        }
        private object get_1_HubPage_DefaultViewModel(object instance)
        {
            var that = (global::Qomo_Hack.HubPage)instance;
            return that.DefaultViewModel;
        }
        private object get_2_Lapor_NavigationHelper(object instance)
        {
            var that = (global::Qomo_Hack.Lapor)instance;
            return that.NavigationHelper;
        }
        private object get_3_Lapor_DefaultViewModel(object instance)
        {
            var that = (global::Qomo_Hack.Lapor)instance;
            return that.DefaultViewModel;
        }
        private object get_4_Login_NavigationHelper(object instance)
        {
            var that = (global::Qomo_Hack.Login)instance;
            return that.NavigationHelper;
        }
        private object get_5_Login_DefaultViewModel(object instance)
        {
            var that = (global::Qomo_Hack.Login)instance;
            return that.DefaultViewModel;
        }
        private object get_6_SectionPage_NavigationHelper(object instance)
        {
            var that = (global::Qomo_Hack.SectionPage)instance;
            return that.NavigationHelper;
        }
        private object get_7_SectionPage_DefaultViewModel(object instance)
        {
            var that = (global::Qomo_Hack.SectionPage)instance;
            return that.DefaultViewModel;
        }
        private object get_8_ItemPage_NavigationHelper(object instance)
        {
            var that = (global::Qomo_Hack.ItemPage)instance;
            return that.NavigationHelper;
        }
        private object get_9_ItemPage_DefaultViewModel(object instance)
        {
            var that = (global::Qomo_Hack.ItemPage)instance;
            return that.DefaultViewModel;
        }
        private object get_10_Signup_NavigationHelper(object instance)
        {
            var that = (global::Qomo_Hack.Signup)instance;
            return that.NavigationHelper;
        }
        private object get_11_Signup_DefaultViewModel(object instance)
        {
            var that = (global::Qomo_Hack.Signup)instance;
            return that.DefaultViewModel;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember xamlMember = null;
            global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Qomo_Hack.HubPage.NavigationHelper":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.HubPage");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "NavigationHelper", "Qomo_Hack.Common.NavigationHelper");
                xamlMember.Getter = get_0_HubPage_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.HubPage.DefaultViewModel":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.HubPage");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "Qomo_Hack.Common.ObservableDictionary");
                xamlMember.Getter = get_1_HubPage_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.Lapor.NavigationHelper":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.Lapor");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "NavigationHelper", "Qomo_Hack.Common.NavigationHelper");
                xamlMember.Getter = get_2_Lapor_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.Lapor.DefaultViewModel":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.Lapor");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "Qomo_Hack.Common.ObservableDictionary");
                xamlMember.Getter = get_3_Lapor_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.Login.NavigationHelper":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.Login");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "NavigationHelper", "Qomo_Hack.Common.NavigationHelper");
                xamlMember.Getter = get_4_Login_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.Login.DefaultViewModel":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.Login");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "Qomo_Hack.Common.ObservableDictionary");
                xamlMember.Getter = get_5_Login_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.SectionPage.NavigationHelper":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.SectionPage");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "NavigationHelper", "Qomo_Hack.Common.NavigationHelper");
                xamlMember.Getter = get_6_SectionPage_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.SectionPage.DefaultViewModel":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.SectionPage");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "Qomo_Hack.Common.ObservableDictionary");
                xamlMember.Getter = get_7_SectionPage_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.ItemPage.NavigationHelper":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.ItemPage");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "NavigationHelper", "Qomo_Hack.Common.NavigationHelper");
                xamlMember.Getter = get_8_ItemPage_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.ItemPage.DefaultViewModel":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.ItemPage");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "Qomo_Hack.Common.ObservableDictionary");
                xamlMember.Getter = get_9_ItemPage_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.Signup.NavigationHelper":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.Signup");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "NavigationHelper", "Qomo_Hack.Common.NavigationHelper");
                xamlMember.Getter = get_10_Signup_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "Qomo_Hack.Signup.DefaultViewModel":
                userType = (global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Qomo_Hack.Signup");
                xamlMember = new global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "Qomo_Hack.Common.ObservableDictionary");
                xamlMember.Getter = get_11_Signup_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlSystemBaseType
    {
        global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::Qomo_Hack.Qomo_Hack_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


