<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GitHubSearch.Default" Async="true" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buscador de Perfil GitHub</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        html, body {
            height: 100%;
        }

        body {
            font-family: Montserrat;
            background: radial-gradient(#81a1c1 25%,#5e81ac  100%);
            background-repeat: no-repeat;
            background-attachment: fixed;
            min-height: 100vh;
            padding: 20px;
        }

        .container {
            max-width: 1000px;
            margin: 0 auto;
        }

        .header {
            text-align: center;
            color: #2e3440;
            margin-bottom: 40px;
        }

        .header h1 {
            font-size: 3em;
            margin-bottom: 10px;
            font-weight: 700;
            letter-spacing: -1px;
        }

        .header p {
            font-size: 1.1em;
            opacity: 0.95;
        }

        .buscar-box {
            background: white;
            padding: 35px;
            border-radius: 12px;
            margin-bottom: 40px;
        }

        .formulario {
            display: flex;
            gap: 12px;
            margin-bottom: 12px;
        }

        .txt-username {
            flex: 1;
            padding: 14px 20px;
            border: 2px solid #e1e4e8;
            border-radius: 8px;
            font-size: 16px;
            transition: all 0.3s ease;
        }

        .txt-username:focus {
            outline: none;
            border-color: #667eea;
            box-shadow: 0 0 0 3px rgba(102, 126, 234, 0.1);
        }

        .btn-buscar, .btn-history {
            padding: 14px 40px;
            background: #5e81ac;
            color: white;
            border: none;
            border-radius: 8px;
            font-size: 16px;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
        }

        .btn-buscar:hover, .btn-history:hover {
            transform: scale(1.05);
        }

        .btn-clear-history {
            padding: 10px 20px;
            background: #d73a49;
            color: white;
            border: none;
            border-radius: 6px;
            font-size: 14px;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
            margin-top: 15px;
        }

        .btn-clear-history:hover {
            transform: scale(1.05);
        }

        .error-message {
            color: #d73a49;
            background-color: #ffeaea;
            padding: 12px 16px;
            border-radius: 6px;
            font-weight: 500;
            margin-top: 0;
        }

        .search-history-section {
            background: white;
            padding: 25px;
            border-radius: 12px;
            margin-bottom: 40px;
        }

        .search-history-section h3 {
            font-size: 1.5em;
            color: #2e3440;
            margin-bottom: 20px;
            font-weight: 700;
        }

        .history-list {
            display: grid;
            grid-template-columns: repeat(auto-fill, minmax(250px, 1fr));
            gap: 15px;
        }

        .history-item {
            background: #f8f9fa;
            padding: 15px;
            border-radius: 8px;
            border-left: 4px solid #667eea;
            transition: all 0.3s ease;
        }

        .history-item:hover {
            transform: scale(1.05);
        }

        .history-item-avatar {
            width: 60px;
            height: 60px;
            border-radius: 50%;
            margin-bottom: 10px;
            object-fit: cover;
            border: 2px solid #667eea;
        }

        .history-item-name {
            font-weight: 700;
            color: #2e3440;
            margin-bottom: 5px;
            font-size: 1.1em;
        }

        .history-item-username {
            color: #2e3440;
            font-size: 0.9em;
            margin-bottom: 10px;
        }

        .history-item-stats {
            display: flex;
            justify-content: space-between;
            font-size: 0.85em;
            color: #2e3440;
            margin-bottom: 10px;
        }

        .history-item-actions {
            display: flex;
            gap: 8px;
        }

        .btn-select-history, .btn-delete-history {
            flex: 1;
            padding: 8px 12px;
            border: none;
            border-radius: 6px;
            font-size: 13px;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
        }

        .btn-select-history {
            background: #667eea;
            color: white;
        }

        .btn-select-history:hover {
            background: #5568d3;
        }

        .btn-delete-history {
            background: #f0f2f5;
            color: #d73a49;
        }

        .btn-delete-history:hover {
            background: #d73a49;
            color: white;
        }

        .user-card {
            background: white;
            padding: 40px;
            border-radius: 12px;
        }

        .user-header {
            display: flex;
            align-items: center;
            gap: 30px;
            margin-bottom: 40px;
            padding-bottom: 30px;
            border-bottom: 2px solid #f0f2f5;
        }

        .avatar {
            width: 120px;
            height: 120px;
            border-radius: 50%;
            border: 4px solid #2e3440;
            object-fit: cover;
            box-shadow: 0 8px 25px rgba(102, 126, 234, 0.3);
        }

        .user-info h2 {
            font-size: 2em;
            color: #2e3440;
            margin-bottom: 5px;
            font-weight: 700;
        }

        .user-info .username {
            color: #2e3440;
            font-size: 1.1em;
            margin-bottom: 20px;
        }

        .stats {
            display: flex;
            gap: 40px;
            flex-wrap: wrap;
        }

        .stat-item {
            display: flex;
            flex-direction: column;
        }

        .stat-value {
            font-size: 1.8em;
            font-weight: 700;
            background: #2e3440;
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
        }

        .stat-label {
            color: #2e3440;
            font-size: 0.95em;
            margin-top: 5px;
        }

        .timeline-section {
            margin-top: 40px;
        }

        .timeline-title {
            font-size: 1.8em;
            margin-bottom: 30px;
            color: #2e3440;
            font-weight: 700;
        }

        .timeline {
            position: relative;
            padding: 20px 0;
        }

        .timeline::before {
            content: '';
            position: absolute;
            left: 30px;
            top: 0;
            bottom: 0;
            width: 2px;
            background: linear-gradient(180deg, #667eea 0%, #764ba2 100%);
        }

        .timeline-item {
            margin-bottom: 30px;
            position: relative;
            padding-left: 100px;
        }

        .timeline-marker {
            position: absolute;
            left: 0;
            top: 5px;
            width: 62px;
            height: 62px;
            background: white;
            border: 4px solid #667eea;
            border-radius: 50%;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 1.4em;
            box-shadow: 0 4px 12px rgba(102, 126, 234, 0.2);
            z-index: 1;
        }

        .timeline-content {
            background: #f8f9fa;
            padding: 20px;
            border-radius: 8px;
            border-left: 3px solid #667eea;
            transition: all 0.3s ease;
        }

        .timeline-item:hover .timeline-content {
            transform: scale(1.05);
        }

        .repo-header {
            display: flex;
            justify-content: space-between;
            align-items: baseline;
            margin-bottom: 12px;
            flex-wrap: wrap;
            gap: 10px;
        }

        .repo-name {
            font-size: 1.3em;
            font-weight: 700;
            color: #2e3440;
        }

        .repo-name a {
            color: inherit;
            text-decoration: none;
        }

        .repo-name a:hover {
            color:green;
        }

        .repo-date {
            font-size: 0.95em;
            color: #2e3440;
            font-weight: 500;
        }

        .repo-description {
            color: #2e3440;
            margin: 12px 0 15px 0;
            line-height: 1.5;
        }

        .repo-description.empty {
            color: #2e3440;
            font-style: italic;
        }

        .repo-stats {
            display: flex;
            gap: 25px;
            font-size: 0.95em;
            color: #2e3440;
            flex-wrap: wrap;
        }

        .repo-stat {
            display: flex;
            align-items: center;
            gap: 6px;
            padding: 4px 10px;
            background: rgba(102, 126, 234, 0.08);
            border-radius: 6px;
        }

        .repo-stat.stars {
            color: #ffc107;
        }

        .repo-stat.forks {
            color: #6f42c1;
        }

        .no-repos-message {
            text-align: center;
            padding: 40px 20px;
            color: #586069;
            font-size: 1.1em;
        }

        .no-history-message {
            text-align: center;
            padding: 20px;
            color: #586069;
            font-size: 1em;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Buscador de Perfil GitHub</h1>
                <p>Genera la linea de tiempo de los repos publicas de cualquier usuario</p>
            </div>

            <div class="buscar-box">
                <div class="formulario">
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="txt-username" 
                        placeholder="Enter GitHub username..." />
                    <asp:Button ID="btnSearch" runat="server" Text="Buscar" 
                        CssClass="btn-buscar" OnClick="btnSearch_Click" />
                </div>
                <asp:Label ID="lblError" runat="server" CssClass="error-message" Visible="false" />
            </div>

            <asp:Panel ID="pnlSearchHistory" runat="server" CssClass="search-history-section" Visible="false">
                <h3>Historial de Búsqueda</h3>
                <div class="history-list">
                    <asp:Repeater ID="rptSearchHistory" runat="server" OnItemCommand="lnkSearchHistory_Command">
                        <ItemTemplate>
                            <div class="history-item">
                                <asp:Image ID="imgHistoryAvatar" runat="server" 
                                    ImageUrl='<%# Eval("AvatarUrl") %>' CssClass="history-item-avatar" />
                                <div class="history-item-name"><%# string.IsNullOrEmpty(Eval("Name")?.ToString()) ? Eval("Username") : Eval("Name") %></div>
                                <div class="history-item-username">@<%# Eval("Username") %></div>
                                <div class="history-item-stats">
                                    <span> <%# Eval("Followers")%> Follow</span>
                                    <span> <%# Eval("PublicRepos")%> Repo</span>
                                </div>
                                <div class="history-item-actions">
                                    <asp:LinkButton ID="lnkSearch" runat="server" 
                                        CssClass="btn-select-history"
                                        CommandName="Search" 
                                        CommandArgument='<%# Eval("Username") %>'>Buscar</asp:LinkButton>
                                    <asp:LinkButton ID="lnkDelete" runat="server" 
                                        CssClass="btn-delete-history"
                                        CommandName="Delete" 
                                        CommandArgument='<%# Eval("SearchID") %>'
                                        OnClientClick="return confirm('¿Eliminar este perfil del historial?');">Eliminar</asp:LinkButton>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <asp:Button ID="btnClearHistory" runat="server" 
                    Text="Limpiar Historial" 
                    CssClass="btn-clear-history" 
                    OnClick="btnClearHistory_Click"
                    OnClientClick="return confirm('¿Eliminar todo el historial de búsqueda?');" />
            </asp:Panel>

            <asp:Panel ID="pnlUserInfo" runat="server" CssClass="user-card" Visible="false">
                <div class="user-header">
                    <asp:Image ID="imgAvatar" runat="server" CssClass="avatar" />
                    <div class="user-info">
                        <h2><asp:Label ID="lblName" runat="server" /></h2>
                        <div class="username">@<asp:Label ID="lblUsername" runat="server" /></div>
                        <div class="stats">
                            <div class="stat-item">
                                <span class="stat-value"><asp:Label ID="lblFollowers" runat="server" /></span>
                                <span class="stat-label">Followers</span>
                            </div>
                            <div class="stat-item">
                                <span class="stat-value"><asp:Label ID="lblRepoCount" runat="server" /></span>
                                <span class="stat-label">Repos publica</span>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="timeline-section">
                    <h3 class="timeline-title">Historial de Repositorios</h3>
                    <div class="timeline">
                        <asp:Repeater ID="rptRepositories" runat="server">
                            <ItemTemplate>
                                <div class="timeline-item">
                                    <div class="timeline-marker">
                                        
                                    </div>
                                    <div class="timeline-content">
                                        <div class="repo-header">
                                            <div class="repo-name"><a href="<%# Eval("html_url") %>"><%# Eval("name") %></a></div>
                                            <div class="repo-date"><%# FormatDate((string)Eval("created_at")) %></div>
                                        </div>
                                        <div class="repo-description <%# string.IsNullOrEmpty(Eval("description")?.ToString()) ? "empty" : "" %>">
                                            <%# string.IsNullOrEmpty(Eval("description")?.ToString()) ? "Sin descripcion" : Eval("description") %>
                                        </div>
                                        <div class="repo-stats">
                                            <span class="repo-stat stars"> <%# Eval("stargazers_count") %> stars</span>
                                            <span class="repo-stat forks"> <%# Eval("forks_count") %> forks</span>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>

    <script runat="server">
        public string FormatDate(string fecha)
        {
            try
            {
                DateTime date = DateTime.Parse(fecha);
                return date.ToString("MMMM d, yyyy");
            }
            catch
            {
                return "Unknown date";
            }
        }

    </script>
</body>
</html>
