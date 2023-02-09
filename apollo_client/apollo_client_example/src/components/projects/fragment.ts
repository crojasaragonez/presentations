import gql from "graphql-tag";

export default gql`
  fragment project on Project {
    id
    name
    state
    start_date
    end_date
    description
    technologies {
      id
      name
    }
    members {
      id
      user {
        id
        name
      }
    }
  }
`;
