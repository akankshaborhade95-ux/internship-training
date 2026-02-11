import { useState } from "react";

export default function SimpleForm() {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [msg, setMsg] = useState("");
  const [data, setData] = useState(null);

  const handleSubmit = e => {
    e.preventDefault();

    setData({ name, email, msg });

    setName("");
    setEmail("");
    setMsg("");
  };

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <input value={name} onChange={e => setName(e.target.value)} placeholder="Name" />
        <input value={email} onChange={e => setEmail(e.target.value)} placeholder="Email" />
        <input value={msg} onChange={e => setMsg(e.target.value)}placeholder="message" />
        <button>Submit</button>
      </form>

      {data && <pre>{JSON.stringify(data, null, 2)}</pre>}
    </div>
  );
}
