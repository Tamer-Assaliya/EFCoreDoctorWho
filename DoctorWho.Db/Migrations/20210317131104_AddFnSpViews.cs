using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorWho.Db.Migrations
{
    public partial class AddFnSpViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE OR ALTER FUNCTION fnCompanion (
                    @EpisodeId INT
                )
                RETURNS VARCHAR(50) AS
                BEGIN
                    Declare @val Varchar(MAX); 
                    SELECT  @val=COALESCE(@val + ', '+ c.CompanionName,c.CompanionName)
                    FROM Companions c
                    JOIN EpisodeCompanion ec
                    ON c.CompanionId=ec.CompanionId AND ec.EpisodeId=@EpisodeId
                   -- PRINT @val;
                    RETURN @val;
                END;
                "
            );
            migrationBuilder.Sql(
                @"GO
                CREATE OR ALTER PROCEDURE spSummariseEpisodes
                AS BEGIN
                  SELECT TOP(3) c.CompanionName, COUNT(*) Companion_count
                  FROM EpisodeCompanion ec
                  JOIN Companion c
                  ON ec.CompanionId=c.CompanionId
                  GROUP BY c.CompanionId , c.CompanionName
                  ORDER BY Companion_count DESC 
                  ---
                  SELECT TOP(3) e.EnemyName, COUNT(*) Enemy_count
                  FROM EpisodeEnemy ee
                  JOIN Enemys e
                  ON ee.EnemyId=e.EnemyId
                  GROUP BY e.EnemyId , e.EnemyName
                  ORDER BY Enemy_count DESC 
                END;"
            );
            migrationBuilder.Sql(
                @"DROP VIEW IF EXISTS viewEpisodes;
                GO
                CREATE VIEW viewEpisodes AS
                  SELECT a.AuthorName, d.DoctorName, fnCompanion(e.EpisodeId) CompanionName, fnEnemies(e.EpisodeId) EnemyName
                  FROM Episodes e
                  JOIN Authors a ON e.AuthorId=a.AuthorId
                  JOIN Doctors d ON e.DoctorId=d.DoctorId"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop FUNCTION fnCompanion");
            migrationBuilder.Sql("Drop PROCEDURE spSummariseEpisodes");
            migrationBuilder.Sql("DROP VIEW viewEpisodes");
        }
    }
}
