//best practice would be seperating into individual files, then make an index.ts that exports them all
export interface NamedApiResource {
  name: string;
  url: string;
}

export interface VersionGroup {
  name: string;
  id: string;
  generation: NamedApiResource[];
  move_learn_methods: NamedApiResource[];
  pokedexes: NamedApiResource[];
  regions: NamedApiResource[];
  versions: NamedApiResource[];
}

