using System;

namespace ch13_automating_clamav_filesystem
{
	public enum ClamEngineDescriptor
	{
		CL_ENGINE_MAX_SCANSIZE,
		CL_ENGINE_MAX_FILESIZE,
		CL_ENGINE_MAX_RECURSION,
		CL_ENGINE_MAX_FILES,
		CL_ENGINE_MIN_CC_COUNT,
		CL_ENGINE_MIN_SSN_COUNT,
		CL_ENGINE_PUA_CATEGORIES,
		CL_ENGINE_DB_OPTIONS,
		CL_ENGINE_DB_VERSION,
		CL_ENGINE_DB_TIME,
		CL_ENGINE_AC_ONLY,
		CL_ENGINE_AC_MINDEPTH,
		CL_ENGINE_AC_MAXDEPTH,
		CL_ENGINE_TMPDIR,
		CL_ENGINE_KEEPTMP,
		CL_ENGINE_BYTECODE_SECURITY,
		CL_ENGINE_BYTECODE_TIMEOUT,
		CL_ENGINE_BYTECODE_MODE
	}
}

