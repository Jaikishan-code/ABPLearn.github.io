namespace TestABP.Permissions;

public static class TestABPPermissions
{
    public const string GroupName = "TestABP";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public class Student
    {
        public const string Default = GroupName + ".Student";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }

    public class Product
    {
        public const string Default = GroupName + ".Product";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
