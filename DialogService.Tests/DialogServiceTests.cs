using DialogService.Items;
using System;
using System.Runtime.InteropServices;
using Xunit;

namespace DialogService.Tests
{
    public class DialogServiceTests
    {
        [Fact]
        public void PlatformTest()
        {
            var dsBuilder = new DialogPlatformBuilder();
            dsBuilder.AddPlatform<Win32.PlatformImplementation>();
            dsBuilder.AddPlatform<Linux.PlatformImplementation>();
            dsBuilder.AddPlatform<MacOS.PlatformImplementation>();
            var dialogService = dsBuilder.GetService();
			
			// TODO: fix tests

            /* if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                Assert.Equal(typeof(Win32.Win32DialogService), dialogService.GetType());
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                Assert.Equal(typeof(Linux.LinuxDialogService), dialogService.GetType());
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                Assert.Equal(typeof(MacOS.MacOSDialogService), dialogService.GetType());
            else throw new NotImplementedException(); */
        }
    }
}
