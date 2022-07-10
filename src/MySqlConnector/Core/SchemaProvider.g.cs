// DO NOT EDIT - generated by SchemaCollectionGenerator.cs
#nullable enable
using MySqlConnector.Protocol.Serialization;
using MySqlConnector.Utilities;

namespace MySqlConnector.Core;

internal sealed partial class SchemaProvider
{
	public async ValueTask<DataTable> GetSchemaAsync(IOBehavior ioBehavior, string collectionName, CancellationToken cancellationToken)
	{
		if (collectionName is null)
			throw new ArgumentNullException(nameof(collectionName));

		var dataTable = new DataTable(collectionName);
		if (string.Equals(collectionName, "MetaDataCollections", StringComparison.OrdinalIgnoreCase))
			await FillMetaDataCollectionsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "CharacterSets", StringComparison.OrdinalIgnoreCase))
			await FillCharacterSetsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Collations", StringComparison.OrdinalIgnoreCase))
			await FillCollationsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "CollationCharacterSetApplicability", StringComparison.OrdinalIgnoreCase))
			await FillCollationCharacterSetApplicabilityAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Columns", StringComparison.OrdinalIgnoreCase))
			await FillColumnsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Databases", StringComparison.OrdinalIgnoreCase))
			await FillDatabasesAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "DataSourceInformation", StringComparison.OrdinalIgnoreCase))
			await FillDataSourceInformationAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "DataTypes", StringComparison.OrdinalIgnoreCase))
			await FillDataTypesAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Engines", StringComparison.OrdinalIgnoreCase))
			await FillEnginesAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "KeyColumnUsage", StringComparison.OrdinalIgnoreCase))
			await FillKeyColumnUsageAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "KeyWords", StringComparison.OrdinalIgnoreCase))
			await FillKeyWordsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Parameters", StringComparison.OrdinalIgnoreCase))
			await FillParametersAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Partitions", StringComparison.OrdinalIgnoreCase))
			await FillPartitionsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Plugins", StringComparison.OrdinalIgnoreCase))
			await FillPluginsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Procedures", StringComparison.OrdinalIgnoreCase))
			await FillProceduresAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "ProcessList", StringComparison.OrdinalIgnoreCase))
			await FillProcessListAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Profiling", StringComparison.OrdinalIgnoreCase))
			await FillProfilingAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "ReferentialConstraints", StringComparison.OrdinalIgnoreCase))
			await FillReferentialConstraintsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "ReservedWords", StringComparison.OrdinalIgnoreCase))
			await FillReservedWordsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "ResourceGroups", StringComparison.OrdinalIgnoreCase))
			await FillResourceGroupsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "SchemaPrivileges", StringComparison.OrdinalIgnoreCase))
			await FillSchemaPrivilegesAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Tables", StringComparison.OrdinalIgnoreCase))
			await FillTablesAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "TableConstraints", StringComparison.OrdinalIgnoreCase))
			await FillTableConstraintsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "TablePrivileges", StringComparison.OrdinalIgnoreCase))
			await FillTablePrivilegesAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "TableSpaces", StringComparison.OrdinalIgnoreCase))
			await FillTableSpacesAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Triggers", StringComparison.OrdinalIgnoreCase))
			await FillTriggersAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "UserPrivileges", StringComparison.OrdinalIgnoreCase))
			await FillUserPrivilegesAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else if (string.Equals(collectionName, "Views", StringComparison.OrdinalIgnoreCase))
			await FillViewsAsync(ioBehavior, dataTable, cancellationToken).ConfigureAwait(false);
		else
			throw new ArgumentException("Invalid collection name: '" + collectionName + "'.", nameof(collectionName));

		return dataTable;
	}

	private Task FillMetaDataCollectionsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("CollectionName", typeof(string)),
			new("NumberOfRestrictions", typeof(int)),
			new("NumberOfIdentifierParts", typeof(int)),
		});

		dataTable.Rows.Add("MetaDataCollections", 0, 0);
		dataTable.Rows.Add("CharacterSets", 0, 0);
		dataTable.Rows.Add("Collations", 0, 0);
		dataTable.Rows.Add("CollationCharacterSetApplicability", 0, 0);
		dataTable.Rows.Add("Columns", 0, 0);
		dataTable.Rows.Add("Databases", 0, 0);
		dataTable.Rows.Add("DataSourceInformation", 0, 0);
		dataTable.Rows.Add("DataTypes", 0, 0);
		dataTable.Rows.Add("Engines", 0, 0);
		dataTable.Rows.Add("KeyColumnUsage", 0, 0);
		dataTable.Rows.Add("KeyWords", 0, 0);
		dataTable.Rows.Add("Parameters", 0, 0);
		dataTable.Rows.Add("Partitions", 0, 0);
		dataTable.Rows.Add("Plugins", 0, 0);
		dataTable.Rows.Add("Procedures", 0, 0);
		dataTable.Rows.Add("ProcessList", 0, 0);
		dataTable.Rows.Add("Profiling", 0, 0);
		dataTable.Rows.Add("ReferentialConstraints", 0, 0);
		dataTable.Rows.Add("ReservedWords", 0, 0);
		dataTable.Rows.Add("ResourceGroups", 0, 0);
		dataTable.Rows.Add("SchemaPrivileges", 0, 0);
		dataTable.Rows.Add("Tables", 0, 0);
		dataTable.Rows.Add("TableConstraints", 0, 0);
		dataTable.Rows.Add("TablePrivileges", 0, 0);
		dataTable.Rows.Add("TableSpaces", 0, 0);
		dataTable.Rows.Add("Triggers", 0, 0);
		dataTable.Rows.Add("UserPrivileges", 0, 0);
		dataTable.Rows.Add("Views", 0, 0);

		return Utility.CompletedTask;
	}

	private async Task FillCharacterSetsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("CHARACTER_SET_NAME", typeof(string)),
			new("DEFAULT_COLLATE_NAME", typeof(string)),
			new("DESCRIPTION", typeof(string)),
			new("MAXLEN", typeof(int)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "CHARACTER_SETS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillCollationsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("COLLATION_NAME", typeof(string)),
			new("CHARACTER_SET_NAME", typeof(string)),
			new("ID", typeof(int)),
			new("IS_DEFAULT", typeof(string)),
			new("IS_COMPILED", typeof(string)),
			new("SORTLEN", typeof(int)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "COLLATIONS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillCollationCharacterSetApplicabilityAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("COLLATION_NAME", typeof(string)),
			new("CHARACTER_SET_NAME", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "COLLATION_CHARACTER_SET_APPLICABILITY", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillColumnsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("TABLE_CATALOG", typeof(string)),
			new("TABLE_SCHEMA", typeof(string)),
			new("TABLE_NAME", typeof(string)),
			new("COLUMN_NAME", typeof(string)),
			new("ORDINAL_POSITION", typeof(uint)),
			new("COLUMN_DEFAULT", typeof(string)),
			new("IS_NULLABLE", typeof(string)),
			new("DATA_TYPE", typeof(string)),
			new("CHARACTER_MAXIMUM_LENGTH", typeof(long)),
			new("NUMERIC_PRECISION", typeof(ulong)),
			new("NUMERIC_SCALE", typeof(ulong)),
			new("DATETIME_PRECISION", typeof(uint)),
			new("CHARACTER_SET_NAME", typeof(string)),
			new("COLLATION_NAME", typeof(string)),
			new("COLUMN_TYPE", typeof(string)),
			new("COLUMN_KEY", typeof(string)),
			new("EXTRA", typeof(string)),
			new("PRIVILEGES", typeof(string)),
			new("COLUMN_COMMENT", typeof(string)),
			new("GENERATION_EXPRESSION", typeof(string)),
			new("SRS_ID", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "COLUMNS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillDatabasesAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("CATALOG_NAME", typeof(string)),
			new("SCHEMA_NAME", typeof(string)),
			new("DEFAULT_CHARACTER_SET_NAME", typeof(string)),
			new("DEFAULT_COLLATION_NAME", typeof(string)),
			new("SQL_PATH", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "SCHEMATA", cancellationToken).ConfigureAwait(false);
	}

	private Task FillDataSourceInformationAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("CompositeIdentifierSeparatorPattern", typeof(string)),
			new("DataSourceProductName", typeof(string)),
			new("DataSourceProductVersion", typeof(string)),
			new("DataSourceProductVersionNormalized", typeof(string)),
			new("GroupByBehavior", typeof(GroupByBehavior)),
			new("IdentifierPattern", typeof(string)),
			new("IdentifierCase", typeof(IdentifierCase)),
			new("OrderByColumnsInSelect", typeof(bool)),
			new("ParameterMarkerFormat", typeof(string)),
			new("ParameterMarkerPattern", typeof(string)),
			new("ParameterNameMaxLength", typeof(int)),
			new("QuotedIdentifierPattern", typeof(string)),
			new("QuotedIdentifierCase", typeof(IdentifierCase)),
			new("ParameterNamePattern", typeof(string)),
			new("StatementSeparatorPattern", typeof(string)),
			new("StringLiteralPattern", typeof(string)),
			new("SupportedJoinOperators", typeof(SupportedJoinOperators)),
		});

		DoFillDataSourceInformation(dataTable);

		return Utility.CompletedTask;
	}

	private Task FillDataTypesAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("TypeName", typeof(string)),
			new("ProviderDbType", typeof(int)),
			new("ColumnSize", typeof(long)),
			new("CreateFormat", typeof(string)),
			new("CreateParameters", typeof(string)),
			new("DataType", typeof(string)),
			new("IsAutoIncrementable", typeof(bool)),
			new("IsBestMatch", typeof(bool)),
			new("IsCaseSensitive", typeof(bool)),
			new("IsFixedLength", typeof(bool)),
			new("IsFixedPrecisionScale", typeof(bool)),
			new("IsLong", typeof(bool)),
			new("IsNullable", typeof(bool)),
			new("IsSearchable", typeof(bool)),
			new("IsSearchableWithLike", typeof(bool)),
			new("IsUnsigned", typeof(bool)),
			new("MaximumScale", typeof(short)),
			new("MinimumScale", typeof(short)),
			new("IsConcurrencyType", typeof(bool)),
			new("IsLiteralSupported", typeof(bool)),
			new("LiteralPrefix", typeof(string)),
			new("LiteralSuffix", typeof(string)),
			new("NativeDataType", typeof(string)),
		});

		DoFillDataTypes(dataTable);

		return Utility.CompletedTask;
	}

	private async Task FillEnginesAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("ENGINE", typeof(string)),
			new("SUPPORT", typeof(string)),
			new("COMMENT", typeof(string)),
			new("TRANSACTIONS", typeof(string)),
			new("XA", typeof(string)),
			new("SAVEPOINTS", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "ENGINES", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillKeyColumnUsageAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("CONSTRAINT_CATALOG", typeof(string)),
			new("CONSTRAINT_SCHEMA", typeof(string)),
			new("CONSTRAINT_NAME", typeof(string)),
			new("TABLE_CATALOG", typeof(string)),
			new("TABLE_SCHEMA", typeof(string)),
			new("TABLE_NAME", typeof(string)),
			new("COLUMN_NAME", typeof(string)),
			new("ORDINAL_POSITION", typeof(int)),
			new("POSITION_IN_UNIQUE_CONSTRAINT", typeof(string)),
			new("REFERENCED_TABLE_SCHEMA", typeof(string)),
			new("REFERENCED_TABLE_NAME", typeof(string)),
			new("REFERENCED_COLUMN_NAME", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "KEY_COLUMN_USAGE", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillKeyWordsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("WORD", typeof(string)),
			new("RESERVED", typeof(int)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "KEYWORDS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillParametersAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("SPECIFIC_CATALOG", typeof(string)),
			new("SPECIFIC_SCHEMA", typeof(string)),
			new("SPECIFIC_NAME", typeof(string)),
			new("ORDINAL_POSITION", typeof(int)),
			new("PARAMETER_MODE", typeof(string)),
			new("PARAMETER_NAME", typeof(string)),
			new("DATA_TYPE", typeof(string)),
			new("CHARACTER_MAXIMUM_LENGTH", typeof(long)),
			new("CHARACTER_OCTET_LENGTH", typeof(long)),
			new("NUMERIC_PRECISION", typeof(int)),
			new("NUMERIC_SCALE", typeof(int)),
			new("DATETIME_PRECISION", typeof(int)),
			new("CHARACTER_SET_NAME", typeof(string)),
			new("COLLATION_NAME", typeof(string)),
			new("DTD_IDENTIFIER", typeof(string)),
			new("ROUTINE_TYPE", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "PARAMETERS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillPartitionsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("TABLE_CATALOG", typeof(string)),
			new("TABLE_SCHEMA", typeof(string)),
			new("TABLE_NAME", typeof(string)),
			new("PARTITION_NAME", typeof(string)),
			new("SUBPARTITION_NAME", typeof(string)),
			new("PARTITION_ORDINAL_POSITION", typeof(int)),
			new("SUBPARTITION_ORDINAL_POSITION", typeof(int)),
			new("PARTITION_METHOD", typeof(string)),
			new("SUBPARTITION_METHOD", typeof(string)),
			new("PARTITION_EXPRESSION", typeof(string)),
			new("SUBPARTITION_EXPRESSION", typeof(string)),
			new("PARTITION_DESCRIPTION", typeof(string)),
			new("TABLE_ROWS", typeof(long)),
			new("AVG_ROW_LENGTH", typeof(long)),
			new("DATA_LENGTH", typeof(long)),
			new("MAX_DATA_LENGTH", typeof(long)),
			new("INDEX_LENGTH", typeof(long)),
			new("DATA_FREE", typeof(long)),
			new("CREATE_TIME", typeof(DateTime)),
			new("UPDATE_TIME", typeof(DateTime)),
			new("CHECK_TIME", typeof(DateTime)),
			new("CHECKSUM", typeof(long)),
			new("PARTITION_COMMENT", typeof(string)),
			new("NODEGROUP", typeof(string)),
			new("TABLESPACE_NAME", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "PARTITIONS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillPluginsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("PLUGIN_NAME", typeof(string)),
			new("PLUGIN_VERSION", typeof(string)),
			new("PLUGIN_STATUS", typeof(string)),
			new("PLUGIN_TYPE", typeof(string)),
			new("PLUGIN_TYPE_VERSION", typeof(string)),
			new("PLUGIN_LIBRARY", typeof(string)),
			new("PLUGIN_LIBRARY_VERSION", typeof(string)),
			new("PLUGIN_AUTHOR", typeof(string)),
			new("PLUGIN_DESCRIPTION", typeof(string)),
			new("PLUGIN_LICENSE", typeof(string)),
			new("LOAD_OPTION", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "PLUGINS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillProceduresAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("SPECIFIC_NAME", typeof(string)),
			new("ROUTINE_CATALOG", typeof(string)),
			new("ROUTINE_SCHEMA", typeof(string)),
			new("ROUTINE_NAME", typeof(string)),
			new("ROUTINE_TYPE", typeof(string)),
			new("DTD_IDENTIFIER", typeof(string)),
			new("ROUTINE_BODY", typeof(string)),
			new("ROUTINE_DEFINITION", typeof(string)),
			new("EXTERNAL_NAME", typeof(string)),
			new("EXTERNAL_LANGUAGE", typeof(string)),
			new("PARAMETER_STYLE", typeof(string)),
			new("IS_DETERMINISTIC", typeof(string)),
			new("SQL_DATA_ACCESS", typeof(string)),
			new("SQL_PATH", typeof(string)),
			new("SECURITY_TYPE", typeof(string)),
			new("CREATED", typeof(DateTime)),
			new("LAST_ALTERED", typeof(DateTime)),
			new("SQL_MODE", typeof(string)),
			new("ROUTINE_COMMENT", typeof(string)),
			new("DEFINER", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "ROUTINES", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillProcessListAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("ID", typeof(long)),
			new("USER", typeof(string)),
			new("HOST", typeof(string)),
			new("DB", typeof(string)),
			new("COMMAND", typeof(string)),
			new("TIME", typeof(int)),
			new("STATE", typeof(string)),
			new("INFO", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "PROCESSLIST", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillProfilingAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("QUERY_ID", typeof(int)),
			new("SEQ", typeof(int)),
			new("STATE", typeof(string)),
			new("DURATION", typeof(decimal)),
			new("CPU_USER", typeof(decimal)),
			new("CPU_SYSTEM", typeof(decimal)),
			new("CONTEXT_VOLUNTARY", typeof(int)),
			new("CONTEXT_INVOLUNTARY", typeof(int)),
			new("BLOCK_OPS_IN", typeof(int)),
			new("BLOCK_OPS_OUT", typeof(int)),
			new("MESSAGES_SENT", typeof(int)),
			new("MESSAGES_RECEIVED", typeof(int)),
			new("PAGE_FAULTS_MAJOR", typeof(int)),
			new("PAGE_FAULTS_MINOR", typeof(int)),
			new("SWAPS", typeof(int)),
			new("SOURCE_FUNCTION", typeof(string)),
			new("SOURCE_FILE", typeof(string)),
			new("SOURCE_LINE", typeof(int)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "PROFILING", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillReferentialConstraintsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("CONSTRAINT_CATALOG", typeof(string)),
			new("CONSTRAINT_SCHEMA", typeof(string)),
			new("CONSTRAINT_NAME", typeof(string)),
			new("UNIQUE_CONSTRAINT_CATALOG", typeof(string)),
			new("UNIQUE_CONSTRAINT_SCHEMA", typeof(string)),
			new("UNIQUE_CONSTRAINT_NAME", typeof(string)),
			new("MATCH_OPTION", typeof(string)),
			new("UPDATE_RULE", typeof(string)),
			new("DELETE_RULE", typeof(string)),
			new("TABLE_NAME", typeof(string)),
			new("REFERENCED_TABLE_NAME", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "REFERENTIAL_CONSTRAINTS", cancellationToken).ConfigureAwait(false);
	}

	private Task FillReservedWordsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("ReservedWord", typeof(string)),
		});

		DoFillReservedWords(dataTable);

		return Utility.CompletedTask;
	}

	private async Task FillResourceGroupsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("RESOURCE_GROUP_NAME", typeof(string)),
			new("RESOURCE_GROUP_TYPE", typeof(string)),
			new("RESOURCE_GROUP_ENABLED", typeof(int)),
			new("VCPU_IDS", typeof(string)),
			new("THREAD_PRIORITY", typeof(int)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "RESOURCE_GROUPS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillSchemaPrivilegesAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("GRANTEE", typeof(string)),
			new("TABLE_CATALOG", typeof(string)),
			new("TABLE_SCHEMA", typeof(string)),
			new("PRIVILEGE_TYPE", typeof(string)),
			new("IS_GRANTABLE", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "SCHEMA_PRIVILEGES", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillTablesAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("TABLE_CATALOG", typeof(string)),
			new("TABLE_SCHEMA", typeof(string)),
			new("TABLE_NAME", typeof(string)),
			new("TABLE_TYPE", typeof(string)),
			new("ENGINE", typeof(string)),
			new("VERSION", typeof(string)),
			new("ROW_FORMAT", typeof(string)),
			new("TABLE_ROWS", typeof(long)),
			new("AVG_ROW_LENGTH", typeof(long)),
			new("DATA_LENGTH", typeof(long)),
			new("MAX_DATA_LENGTH", typeof(long)),
			new("INDEX_LENGTH", typeof(long)),
			new("DATA_FREE", typeof(long)),
			new("AUTO_INCREMENT", typeof(long)),
			new("CREATE_TIME", typeof(DateTime)),
			new("UPDATE_TIME", typeof(DateTime)),
			new("CHECK_TIME", typeof(DateTime)),
			new("TABLE_COLLATION", typeof(string)),
			new("CHECKSUM", typeof(string)),
			new("CREATE_OPTIONS", typeof(string)),
			new("TABLE_COMMENT", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "TABLES", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillTableConstraintsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("CONSTRAINT_CATALOG", typeof(string)),
			new("CONSTRAINT_SCHEMA", typeof(string)),
			new("CONSTRAINT_NAME", typeof(string)),
			new("TABLE_SCHEMA", typeof(string)),
			new("TABLE_NAME", typeof(string)),
			new("CONSTRAINT_TYPE", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "TABLE_CONSTRAINTS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillTablePrivilegesAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("GRANTEE", typeof(string)),
			new("TABLE_CATALOG", typeof(string)),
			new("TABLE_SCHEMA", typeof(string)),
			new("TABLE_NAME", typeof(string)),
			new("PRIVILEGE_TYPE", typeof(string)),
			new("IS_GRANTABLE", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "TABLE_PRIVILEGES", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillTableSpacesAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("TABLESPACE_NAME", typeof(string)),
			new("ENGINE", typeof(string)),
			new("TABLESPACE_TYPE", typeof(string)),
			new("LOGFILE_GROUP_NAME", typeof(string)),
			new("EXTENT_SIZE", typeof(long)),
			new("AUTOEXTEND_SIZE", typeof(long)),
			new("MAXIMUM_SIZE", typeof(long)),
			new("NODEGROUP_ID", typeof(long)),
			new("TABLESPACE_COMMENT", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "TABLESPACES", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillTriggersAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("TRIGGER_CATALOG", typeof(string)),
			new("TRIGGER_SCHEMA", typeof(string)),
			new("TRIGGER_NAME", typeof(string)),
			new("EVENT_MANIPULATION", typeof(string)),
			new("EVENT_OBJECT_CATALOG", typeof(string)),
			new("EVENT_OBJECT_SCHEMA", typeof(string)),
			new("EVENT_OBJECT_TABLE", typeof(string)),
			new("ACTION_ORDER", typeof(long)),
			new("ACTION_CONDITION", typeof(string)),
			new("ACTION_STATEMENT", typeof(string)),
			new("ACTION_ORIENTATION", typeof(string)),
			new("ACTION_TIMING", typeof(string)),
			new("ACTION_REFERENCE_OLD_TABLE", typeof(string)),
			new("ACTION_REFERENCE_NEW_TABLE", typeof(string)),
			new("ACTION_REFERENCE_OLD_ROW", typeof(string)),
			new("ACTION_REFERENCE_NEW_ROW", typeof(string)),
			new("CREATED", typeof(DateTime)),
			new("SQL_MODE", typeof(string)),
			new("DEFINER", typeof(string)),
			new("CHARACTER_SET_CLIENT", typeof(string)),
			new("COLLATION_CONNECTION", typeof(string)),
			new("DATABASE_COLLATION", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "TRIGGERS", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillUserPrivilegesAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("GRANTEE", typeof(string)),
			new("TABLE_CATALOG", typeof(string)),
			new("PRIVILEGE_TYPE", typeof(string)),
			new("IS_GRANTABLE", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "USER_PRIVILEGES", cancellationToken).ConfigureAwait(false);
	}

	private async Task FillViewsAsync(IOBehavior ioBehavior, DataTable dataTable, CancellationToken cancellationToken)
	{
		dataTable.Columns.AddRange(new DataColumn[]
		{
			new("TABLE_CATALOG", typeof(string)),
			new("TABLE_SCHEMA", typeof(string)),
			new("TABLE_NAME", typeof(string)),
			new("VIEW_DEFINITION", typeof(string)),
			new("CHECK_OPTION", typeof(string)),
			new("IS_UPDATABLE", typeof(string)),
			new("DEFINER", typeof(string)),
			new("SECURITY_TYPE", typeof(string)),
			new("CHARACTER_SET_CLIENT", typeof(string)),
			new("COLLATION_CONNECTION", typeof(string)),
		});

		await FillDataTableAsync(ioBehavior, dataTable, "VIEWS", cancellationToken).ConfigureAwait(false);
	}

}
