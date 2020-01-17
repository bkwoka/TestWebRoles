namespace testWebRoles.Models
{
    public class ViewStatisticsModel
    {
        public int UsersCount { get; set; }

        public ViewStatisticsModel(int userCount)
        {
            UsersCount = userCount;
        }
    }
}
