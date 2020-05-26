using System;
using TravisSampleLibrary;
using Xunit;

namespace ClassLibrar
{
    public class AuthorizeTest
    {
        [Fact]
        public void SuccessAuthorize()
        {
            var auth = new HardCodeAuthorize();
            var result = auth.Auth("user", "pass");
            Assert.Equal(true,result);
        }
        
        [Fact]
        public void FiledAuthorize()
        {
            var auth = new HardCodeAuthorize();
            var result = auth.Auth("user", "eeee");
            Assert.Equal(false,result);
        }
    }
}