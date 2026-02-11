import { useState, useEffect } from "react";

export default function UserSearch() {
  const [users, setUsers] = useState([]);
  const [search, setSearch] = useState("");
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetch("https://jsonplaceholder.typicode.com/users")
      .then(res => res.json())
      .then(data => {
        setUsers(data);
        setLoading(false);
      });
  }, []);

  const filtered = users.filter(user =>
    user.name.toLowerCase().includes(search.toLowerCase())
  );

  return (
    <div className="project-box">
      <h3>User Search App</h3>

      <input
        placeholder="Search by name..."
        onChange={(e) => setSearch(e.target.value)}
      />

      {loading && <p>Loading...</p>}

      {filtered.map(user => (
        <div key={user.id}>
          <p><b>{user.name}</b></p>
          <p>{user.email}</p>
          <hr />
        </div>
      ))}
    </div>
  );
}
