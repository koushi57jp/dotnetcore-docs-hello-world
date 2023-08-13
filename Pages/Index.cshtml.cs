using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;

namespace dotnetcoresample.Pages;

public class IndexModel : PageModel
{

    public string OSVersion { get { return RuntimeInformation.OSDescription; }  }
    
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {        
    }

    public string test {
        get {
            // URLを取得
            const url = new URL(window.location.href);
        
            // URLSearchParamsオブジェクトを取得
            const params = url.searchParams;
        
            // パラメータから「username」を取得
            const session_token = params.get("session_token");
        
            return session_token;
        }
    }
}
