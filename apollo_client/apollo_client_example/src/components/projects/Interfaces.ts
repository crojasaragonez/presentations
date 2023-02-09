export interface IdName {
  id: string;
  name: string;
}

interface ProjectMember {
  id: string;
  user: IdName;
}

interface PaginationInfo {
  hasMorePages: boolean;
}

export interface Project {
  id: string;
  name: string;
  state: string;
  start_date: string;
  end_date: string;
  description: string;
  technologies: IdName[];
  members: ProjectMember[];
  dispose: {
    members: string[];
  };
}

export interface ProjectResponse {
  data: Project[];
  paginatorInfo: PaginationInfo;
}
