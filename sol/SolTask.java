import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class SolTask {
	public static void main(String[] args) {
		try {
			Class.forName("com.mysql.jdbc.Driver");
			Connection con=DriverManager.getConnection( 
					 
				    "jdbc:mysql://localhost:3306/sqlpractice","root","root");
			System.out.println("Connected...");
			String cmd="SELECT * FROM Courses";
			PreparedStatement pst=con.prepareStatement(cmd);
			ResultSet rs=pst.executeQuery();
			int courseId;
			String column1,column2,column3;
			while(rs.next()) {
				courseId=rs.getInt("COURSEID");
				column1=rs.getString("FirstOption");
				column2=rs.getString("SecondOption");
				column3=rs.getString("ThirdOption");
				if(column1.equals("A") && column2.equals("B")
						&& column3.equals("C")) {
					String cmdUpdate="UPDATE COURSES SET RESULT=? WHERE "
							+ " COURSEID=?";
					PreparedStatement pstUpd=con.prepareStatement(cmdUpdate);
					pstUpd.setString(1,"Y");
					pstUpd.setInt(2, courseId);
					pstUpd.executeUpdate();
				}
				if(column1.equals("a") && column2.equals("b")
						&& column3.equals("c")) {
					String cmdUpdate="UPDATE COURSES SET RESULT=? WHERE "
							+ " COURSEID=?";
					PreparedStatement pstUpd=con.prepareStatement(cmdUpdate);
					pstUpd.setString(1,"x");
					pstUpd.setInt(2, courseId);
					pstUpd.executeUpdate();
				}
			}
			System.out.println("Data Updated...");
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		

	}
}
