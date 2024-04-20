import { GridColDef } from "@mui/x-data-grid";
import DataTable from "../../components/dataTable/DataTable";
import "./Staffs.scss";
import { useState } from "react";
import Add from "../../components/add/Add";
import { userRows } from "../../data";
import { useQuery } from "@tanstack/react-query";
import { Loading } from '@/components/shared';
import axios from "axios";

interface Staff {
  id: number;
  name: string;
  email: string;
  phone: string;
  dateOfBirth: string;
  avatarUrl: string;
}

const columns: GridColDef[] = [
  { field: "id", headerName: "ID", width: 50 },
  {
    field: "name",
    type: "string",
    headerName: "Name",
    width: 150,
  },
  /*{
    field: "lastName",
    type: "string",
    headerName: "Last name",
    width: 150,
  },*/
  {
    field: "email",
    type: "string",
    headerName: "Email",
    width: 250,
  },
  {
    field: "phone",
    type: "string",
    headerName: "Phone",
    width: 130,
  },
  {
    field: "dateOfBirth",
    headerName: "Date of birth",
    width: 100,
    type: "date",
  },
  {
    field: "avatarUrl",
    headerName: "Avatar",
    width: 100,
    renderCell: (params) => {
      return <img src={params.row.img || "/noavatar.png"} alt="" />;
    },
  },
  {
    field: "gender",
    headerName: "gender",
    width: 150,
    type: "String",
  },
  {
    field: "status",
    headerName: "Status",
    width: 150,
    type: "boolean",
  },
];

const Staff = () => {
  const [open, setOpen] = useState(false);
  const [isLoading, setIsLoading] = useState(true);
  const [data, setData] = useState([] as Staff[]);
  const apiGetStaffUsers = async (pageNumber: number, pageSize: number) => {
    const url = `https://localhost:7152/api/User/getAllUser?pageNumber=${pageNumber}&pageSize=${pageSize}`;
    try {
      const respone = await axios.get(url);
      if (respone.status === 200) {
        setIsLoading(false);
        setData(respone.data);
      } else {
        console.error;
      }

    } catch(error) { 
      console.error(error);
    }

    }

  // TEST THE API

   /*const { isLoading, data } = useQuery({
     queryKey: ["allStaff"],
     queryFn: () =>
       fetch("http://localhost:8800/api/Staff").then(
         (res) => res.json()
       ),
   });*/

  return (
    <div className="Staff">
      <div className="info">
        <h1>Staff</h1>
        <button onClick={() => setOpen(true)}>Add New User</button>
      </div>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
            <th>Date of birth</th>
            <th>Avatar</th>
          </tr>
        </thead>
      </table>
      <tbody> 
      {
  data.map((staff: Staff, index: number) => {
    return (
      <tr key={index}>
        <td>{staff.id}</td>
        <td>{staff.name}</td>
        <td>{staff.email}</td>
        <td>{staff.phone}</td>
        <td>{staff.dateOfBirth}</td>
        <td><img src={staff.avatarUrl} alt="" /></td>
      </tr>
    );
  })
}
      </tbody>
      
      {/* TEST THE API */}

      {/* {isLoading ? (
        "Loading..."
      ) : (
        <DataTable slug="Staff" columns={columns} rows={data} />
      )} */}
      {open && <Add slug="user" columns={columns} setOpen={setOpen} />}
    </div>
  );
};

export default Staff;
