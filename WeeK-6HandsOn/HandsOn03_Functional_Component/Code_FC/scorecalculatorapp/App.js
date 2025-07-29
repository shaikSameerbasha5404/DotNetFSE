import { CalculateScore } from "./Components/Calculatescore";

function App() {
  return (
    <div className="App">
      <CalculateScore
        Name="Gowtham B V"
        School="SEC, Chennai"
        total={87}
        goal={100}
      />
    </div>
  );
}

export default App;
