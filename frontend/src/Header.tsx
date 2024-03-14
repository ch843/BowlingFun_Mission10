import bowlingImg from './bowling_stock.jpg';

function Image() {
  return (
    <div
      className="row"
      style={{
        display: 'flex',
        flexFlow: 'row nowrap',
        justifyContent: 'center',
        marginTop: '2em',
      }}
    >
      <img
        src={bowlingImg}
        alt="bowling stock photo"
        style={{ maxWidth: '50%' }}
      />
    </div>
  );
}

function Welcome() {
  return (
    <div className="text-center mt-5 row">
      <h1>Bowler Information</h1>
      <small>
        This page shows bowlers from the Marlins and Sharks teams and their
        information
      </small>
    </div>
  );
}

function Header() {
  return (
    <>
      <Welcome />
      <Image />
    </>
  );
}

export default Header;
