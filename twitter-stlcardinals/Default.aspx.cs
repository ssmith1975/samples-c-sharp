using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Diagnostics;
using System.Data;

using System.Linq.Expressions;
using LinqToTwitter;
using System.Configuration;



public partial class _Default : System.Web.UI.Page
{
    // Properties
    private TwitterContext twitterCtx;
    private ApplicationOnlyAuthorizer auth;
    private PagedDataSource pds;

    // Constants
    const string SEARCHTEXT = "#stlcardinals"; // Search query
    const int SEARCHCOUNT = 25; // Return 25 most recent tweets
    const int REFRESHRATE = 300; // Interval (seconds)


    protected void Page_Load(object sender, EventArgs e)
    {
        // Initialize object for paging
        pds = new PagedDataSource();
        pds.AllowPaging = true;
        pds.PageSize = 5;

        // In v1.1, all API calls require authentication
        // Authentication
        auth = new ApplicationOnlyAuthorizer
        {
            Credentials = new InMemoryCredentials
            {
                ConsumerKey = ConfigurationManager.AppSettings["TwitterConsumerKey"],  // Custom Custom Consumer Key 
                ConsumerSecret = ConfigurationManager.AppSettings["TwitterConsumerSecret"] // Custom Consumer Secret
            }
        };

        // Authorize
        auth.Authorize();

        // Instantiate a LinqToTwitter object
        twitterCtx = new TwitterContext(auth);

        // On first load
        if(! Page.IsPostBack){

            // Initialize viewstate variables
            this.ViewState["CurrentPageIndex"] = 0;
            this.ViewState["PageCount"] = 0;

            // Invoke twitter databind
            TwitterDataBind();

            // Set timer interval
            Timer1.Interval = REFRESHRATE * 1000;

        } // end if IsPostBack

    } // Page_Load
/**
 * METHODS
 */ 
    public void TwitterDataBind()
    {

        // Build table for twitter search results
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        // Create table columns
        dt.Columns.Add("ScreenName", typeof(string));
        dt.Columns.Add("Text", typeof(string));
        dt.Columns.Add("Photo", typeof(string));

        try{
        // Grab twitter results
        var tweets = GetTwitterResults();


            // Insert twitter results into table
            foreach (var tweet in tweets)
            {
                // Add row to table
                dt.Rows.Add(tweet.User.Identifier.ScreenName, tweet.Text, tweet.User.ProfileImageUrl);

            }

            // Use table in paged datasource
            pds.DataSource = dt.DefaultView;

            // Set current page index based on navigation Previous/Next buttons
            pds.CurrentPageIndex = CurrentPageIndex;

            // Save page count into PageCount property
            PageCount = pds.PageCount;

            // Bind table data to datalist
            DataList1.DataSource = pds;
            DataList1.DataBind();

            // Set dataset and datatable objects to null
            ds = null;
            dt = null;

            // Update status text
            lbFeedlStatus.Text = String.Format("Last update: {0}", DateTime.Now.ToString());
        } catch(Exception ex){
            // Add dummy content to table
            dt.Rows.Add("homeRunner", "It feels good waking up every morning and knowing the Cardinals are the best team in baseball", "Images/profile.png");
            dt.Rows.Add("cardinalsfans", "Oh crap!!! The #Cardinals didn't win yesterday!! Oh wait it was an off day.", "Images/profile.png");
            dt.Rows.Add("sportsaholic", "The St. Louis Cardinals begins a three-game series tonight against the Mets in New York.", "Images/profile.png");
            dt.Rows.Add("RamsNation", "Are you following the St Louis Cardinals?", "Images/profile.png");
            dt.Rows.Add("emiliaWineHeart", "Cardinals fan fest today, wish someone would take me.", "Images/profile.png");
            // Add table to dataset
            ds.Tables.Add(dt);

            // Bind table data to datalist
            DataList1.DataSource = ds;
            DataList1.DataBind();

            // Update status text
            lbFeedlStatus.Text = String.Format("An error occurred: {0}", ex.Message);
        }




    } // TwitterDataBind

    protected List<Status> GetTwitterResults(){
        

        if (auth.IsAuthorized)
        {
            // Query Twitter
            var search = (from srch in twitterCtx.Search
                          where srch.Type == SearchType.Search &&
                                srch.Query == SEARCHTEXT &&
                                srch.Count == SEARCHCOUNT
                          select srch)
                .SingleOrDefault();

            // Return search statuses
             return search.Statuses;

         }   else {
            // Error
            lbFeedlStatus.Text = "Error";
            return null;
         }


    } // end GetTwitterResults

    /**
     * PROPERTIES
     * /
    
    /* CurrentPageIndex - Keeps track of paging index. Saves to viewstate variable. */
    public int CurrentPageIndex
    {
        get
        {
            if (this.ViewState["CurrentPageIndex"] == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt16(this.ViewState["CurrentPageIndex"].ToString());
            }
        }
        set
        {
            this.ViewState["CurrentPageIndex"] = value;
        }
    } // Current PageIndex

    /* PageCount -- Keeps track of number of pages. Saves to viewstate variable */
    public int PageCount
    {
        get
        {
            return Convert.ToInt16(this.ViewState["PageCount"].ToString());
        }
        set
        {
            this.ViewState["PageCount"] = value;
        }
    } // PageCount


    /**
     * EVENTS
     */

    
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        // Periodically refresh twitter results
        TwitterDataBind();

    } // Timer1_Tick

    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        // Check which command button was pressed
        switch (e.CommandName)
        {
            case "NextPage":
                // Increment page index to display next paged results
                CurrentPageIndex++;
                
                // Refresh Twitter Results
                TwitterDataBind();
                break;
            case "PrevPage":
                // Decrement page index to display previous paged results
                CurrentPageIndex--;
                
                // Refresh Twitter Results
                TwitterDataBind();
                break;

        }

    } // DataList1_ItemCommand

    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Footer)
        {
            // Reference navigation buttons
            LinkButton btnPrev = (LinkButton)e.Item.FindControl("btnPrev");
            LinkButton btnNext = (LinkButton)e.Item.FindControl("btnNext");

            // Set button state for btnPrev

            if (CurrentPageIndex == 0)
            {
                // Disable
                btnPrev.Enabled = false;

                // Swap button style
                btnPrev.CssClass = "twitterBtnPrevDisabled navLeft";

            } else {
                // Enable
                btnPrev.Enabled = true;

                // Swap button style
                btnPrev.CssClass = "twitterBtnPrev navLeft";
            }


            // Set button state for btnNext
            if (CurrentPageIndex >= PageCount - 1)
            {
                // Disable
                btnNext.Enabled = false;

                // Swap button style
                btnNext.CssClass = "twitterBtnNextDisabled navRight";

            } else {
                // Enable
                btnNext.Enabled = true;
                // Swap button style
                btnNext.CssClass = "twitterBtnNext navRight";
            }

            // Set current page number
            Label lblPage = (Label)e.Item.FindControl("lblPage");
            lblPage.Text = "Page " + (CurrentPageIndex + 1);


        } // end if
    } // DataList1_ItemDataBound

}