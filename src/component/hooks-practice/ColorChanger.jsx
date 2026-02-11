import { useState } from "react";
export default function ColorChanger() {
  const [color, setColor] = useState("white");
  const colors = ["pink", "black", "white", "blue", "purple"];
  return (
    <div style={{ background: color, padding: "40px" }}>
      <h3>Current: {color}</h3>
      {colors.map(c => (
        <button key={c} onClick={() => setColor(c)}>
          {c}
        </button>
      ))}
    </div>
  );
}