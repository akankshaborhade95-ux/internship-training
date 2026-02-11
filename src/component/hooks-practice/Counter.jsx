import { useState } from "react";
export default function Counter() {
  const [count, setCount] = useState(0);
  return (
    <div>
      <h2>{count}</h2>
      <button onClick={() => setCount(count + 1)}>+1</button>
      <button
        onClick={() => count > 0 && setCount(count - 1)}
        disabled={count === 0}
      >
        -1
      </button>

      <button onClick={() => setCount(0)}>Reset</button>
    </div>
  );
}
