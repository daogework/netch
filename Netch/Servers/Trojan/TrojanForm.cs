﻿using Netch.Forms;

namespace Netch.Servers;

[Fody.ConfigureAwait(true)]
public class TrojanForm : ServerForm
{
    public TrojanForm(TrojanServer? server = default)
    {
        server ??= new TrojanServer();
        Server = server;
        CreateTextBox("Password", "Password", s => true, s => server.Password = s, server.Password);
        CreateTextBox("Host", "Host", s => true, s => server.Host = s, server.Host);
    }

    protected override string TypeName { get; } = "Trojan";
}