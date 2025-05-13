<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
    <system.serviceModel>
        <bindings>
            <netTcpBinding>
                <binding name="NetTcpEndpoint_IActivity">
                    <security>
                        <transport sslProtocols="None" />
                    </security>
                </binding>
            </netTcpBinding>
        </bindings>
        <client>
            <endpoint address="net.tcp://lsr530svr:40200/Services/AppServices/Activity"
                binding="netTcpBinding" bindingConfiguration="NetTcpEndpoint_IActivity"
                contract="ActivityRef.AppServices" name="NetTcpEndpoint_IActivity">
                <identity>
                    <userPrincipalName value="LSR530SVR\mngr" />
                </identity>
            </endpoint>
        </client>
    </system.serviceModel>
</configuration>
