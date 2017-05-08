using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace Cppcheck_VS_AddIn
{
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", Vsix.Version, IconResourceID = 400)]       
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(PackageGuids.guidCppcheckCommandPackageString)]
    public sealed class VSPackage : Package
    {

        public VSPackage()
        {
        }

        protected override void Initialize()
        {
            CppcheckCommand.Initialize(this);
            base.Initialize();
        }

    }
}
