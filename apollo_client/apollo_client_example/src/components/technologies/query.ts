import gql from "graphql-tag";

export default gql`
  query {
    technologies: dropdown(type: Technology) {
      id
      name
    }
  }
`;
